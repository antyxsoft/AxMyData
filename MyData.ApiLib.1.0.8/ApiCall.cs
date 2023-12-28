using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MyData.ApiLib
{
 

    /// <summary>
    /// Represents the response of a call to the Api
    /// </summary>
    internal class ApiCall : EventArgs
    {
 
        /* construction */
        /// <summary>
        /// Constructor
        /// </summary>
        public ApiCall(string ActionUrl, object Packet = null)
        {
            this.ActionUrl = ActionUrl;
        }


        /* public */
        /// <summary>
        /// Loads this instance from a specified http response
        /// </summary>
        public virtual async Task LoadFromResponseAsync(HttpResponseMessage Response)
        {
            this.ActionUrl = !string.IsNullOrWhiteSpace(ActionUrl) ? ActionUrl : Response.RequestMessage.RequestUri.ToString();
            this.Response = Response;
            this.StatusCode = Response.StatusCode;
            this.ReasonPhrase = Response.ReasonPhrase;
            this.IsSuccess = Response.IsSuccessStatusCode;

            if (this.IsSuccess)
            {
                ResponseText = await Response.Content.ReadAsStringAsync();
            }
        }
        /// <summary>
        /// Deserializes the response text into an object.
        /// </summary>
        public virtual T Deserialize<T>() where T : class
        {
            if (!string.IsNullOrWhiteSpace(ResponseText))
                return ApiXml.Deserialize<T>(ResponseText);
            return default(T);
        }
 
        /* properties */
        /// <summary>
        /// The action url of the call
        /// </summary>
        public string ActionUrl { get; private set; }
        /// <summary>
        /// The type of the call
        /// </summary>
        public ApiClientCallType CallType { get; }
        /// <summary>
        /// The packet, if any, else null. 
        /// Used by Post only.
        /// </summary>
        public object Packet { get; }
        /// <summary>
        /// User defined.
        /// </summary>
        public object Tag { get; set; }
 

        /* response properties */
        /// <summary>
        /// True when the call succeeds network-wise.
        /// </summary>
        public bool IsSuccess { get; set; }
        /// <summary>
        /// The HTTP status code of the call
        /// </summary>
        public HttpStatusCode StatusCode { get; set; }
        /// <summary>
        /// The Response object.
        /// CAUTION: It is null before the OnAfter() event and it is disposed right after the OnAfter() event.
        /// <para>It lives just inside the OnAfter() event.</para>
        /// </summary>
        public HttpResponseMessage Response { get; set; }
        /// <summary>
        /// The reason text sent by the server together with the status code
        /// </summary>
        public string ReasonPhrase { get; set; }
        /// <summary>
        /// The XML or JSON text returned by the api call.
        /// </summary>
        public string ResponseText { get; set; }
    }
}
