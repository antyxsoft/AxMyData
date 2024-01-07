namespace MyData.Xsd
{
    public class TransmissionFailure
    {
        static List<TransmissionFailure> fList;

        public TransmissionFailure(int Value, string Name)
        {
            this.Value = Value;
            this.Name = Name.Trim();
        }

        public override string ToString()
        {
            return Name;
        }

        public int Value { get; }
        public string Name { get; }

        public static List<TransmissionFailure> List
        {
            get
            {
                if (fList == null)
                {
                    fList = new List<TransmissionFailure>();

                    fList.Add(new TransmissionFailure(1, "Αδυναμία επικοινωνίας οντότητας με τον πάροχο κατά την έκδοση/διαβίβαση παραστατικού"));
                    fList.Add(new TransmissionFailure(2, "Αδυναμία επικοινωνίας του παρόχου με το myDATA κατά την έκδοση/διαβίβαση παραστατικού"));
                    fList.Add(new TransmissionFailure(3, "Απώλεια διασύνδεσης του ERP με myDATA"));
                }
 
                return fList;
            }
        }

    }
}
