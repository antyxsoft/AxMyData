namespace MyData.Xsd
{

    /// <summary>
    /// Παράρτημα: Τρόποι Πληρωμής
    /// <para>FOR: <see cref="PaymentMethodDetailType.type"/> property </para>
    /// <para>XSD Type: no type</para>
    /// </summary>
    public class PaymentType
    {
        static List<PaymentType> fList;

        public PaymentType(int Value, string Name)
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

        public static List<PaymentType> List
        {
            get
            {
                if (fList == null)
                {
                    fList = new List<PaymentType>();

                    fList.Add(new PaymentType(1, "Επαγ. Λογαριασμός Πληρωμών Ημεδαπής "));
                    fList.Add(new PaymentType(2, "Επαγ. Λογαριασμός Πληρωμών Αλλοδαπής"));
                    fList.Add(new PaymentType(3, "Μετρητά "));
                    fList.Add(new PaymentType(4, "Επιταγή "));
                    fList.Add(new PaymentType(5, "Επί Πιστώσει "));
                    fList.Add(new PaymentType(6, "Web Banking "));
                    fList.Add(new PaymentType(7, "POS / e-POS"));
                }

                return fList;
            }
        }
    }




}
