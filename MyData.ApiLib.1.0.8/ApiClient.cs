using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace MyData.ApiLib
{

    /// <summary>
    /// A base "typed" <see cref="HttpClient"/>.
    /// <para>Links: 
    /// <list type="bullet">
    /// <item>https://blogs.msdn.microsoft.com/henrikn/2012/08/07/httpclient-httpclienthandler-and-webrequesthandler-explained/ </item>
    /// <item>https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests </item>
    /// </list>
    /// </para>
    /// </summary>
    internal class ApiClient
    {
        /* private */
        HttpClient Client = new HttpClient();

        /// <summary>
        /// Prepares request headers
        /// </summary>
        void PrepareHeaders(string UserName, string UserKey)
        {
            if (Client.DefaultRequestHeaders.Accept == null || !Client.DefaultRequestHeaders.Accept.Any(m => m.MediaType == MediaTypeNames.Application.Xml))
            {
                Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(MediaTypeNames.Application.Xml));
            }

            Client.DefaultRequestHeaders.Add("aade-user-id", UserName);
            Client.DefaultRequestHeaders.Add("ocp-apim-subscription-key", UserKey);
        }

        /* construction */
        /// <summary>
        /// Construction
        /// </summary>
        public ApiClient(string BaseUrl) 
        {
            Client.BaseAddress = new Uri(BaseUrl);
        }

        /* public */
        /// <summary>
        /// Executes a POST Action to Api
        /// </summary>
        public async Task<ApiCall> PostAsync(string UserName, string UserKey, string ActionUrl, object Packet)
        {
            ApiCall Info = new ApiCall(ActionUrl);             
            try
            {
                PrepareHeaders(UserName, UserKey);
                if (OnBefore != null)
                    OnBefore(this, Info);

                string XmlText = string.Empty;
                StringContent Content = null;

                // AMAZING: They have POST call without body content
                if (Packet != null)
                {
                    XmlText = ApiXml.Serialize(Packet);
                    Content = new StringContent(XmlText, Encoding.UTF8, MediaTypeNames.Application.Xml);
                }

                // SEE: async_await.txt for the ConfigureAwait(false)
                using (HttpResponseMessage Response = await Client.PostAsync(ActionUrl, Content).ConfigureAwait(false))
                {
                    await Info.LoadFromResponseAsync(Response).ConfigureAwait(false);

                    Info.IsSuccess = true;

                    if (OnAfter != null)
                        OnAfter(this, Info);
                }
            }
            catch (Exception Ex)
            {
                Info.ReasonPhrase = Ex.Message;
                Info.IsSuccess = false;
            }

            if (!Info.IsSuccess && OnError != null)
                OnError(this, Info);

            return Info;
        }
        /// <summary>
        /// Executes a GET Action to Api
        /// </summary>
        public async Task<ApiCall> GetAsync(string UserName, string UserKey, string ActionUrl)
        {
            ApiCall Info = new ApiCall(ActionUrl);
            try
            {
                PrepareHeaders(UserName, UserKey);
                if (OnBefore != null)
                    OnBefore(this, Info);

                // SEE: async_await.txt for the ConfigureAwait(false)
                using (HttpResponseMessage Response = await Client.GetAsync(ActionUrl).ConfigureAwait(false))
                {
                    await Info.LoadFromResponseAsync(Response).ConfigureAwait(false);

                    Info.IsSuccess = true;

                    if (OnAfter != null)
                        OnAfter(this, Info);
                }

            }
            catch (Exception Ex)
            {
                Info.ReasonPhrase = Ex.Message;
                Info.IsSuccess = false;
            }

            if (!Info.IsSuccess && OnError != null)
                OnError(this, Info);

            return Info;
        }

        /* events */ 
        /// <summary>
        /// Occurs before Api call
        /// </summary>
        public event EventHandler<ApiCall> OnBefore;
        /// <summary>
        /// Occurs after Api call
        /// </summary>
        public event EventHandler<ApiCall> OnAfter;
        /// <summary>
        /// Occurs on Api errors
        /// </summary>
        public event EventHandler<ApiCall> OnError;
    }
}
