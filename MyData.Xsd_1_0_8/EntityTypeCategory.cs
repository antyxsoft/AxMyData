namespace MyData.Xsd
{
    /// <summary>
    /// Παράρτημα: Κατηγορία Οντότητας
    /// <para>FOR: <see cref="EntityType.type"/> property </para>
    /// <para>XSD Type: no type</para>
    /// </summary>
    public class EntityTypeCategory
    {
        static List<EntityTypeCategory> fList;

        public EntityTypeCategory(int Value, string Name)
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

        public static List<EntityTypeCategory> List
        {
            get
            {
                if (fList == null)
                {
                    fList = new List<EntityTypeCategory>();

                    fList.Add(new EntityTypeCategory(1, "Φορολογικός Εκπρόσωπος"));
                    fList.Add(new EntityTypeCategory(2, "Διαμεσολαβητής"));
                    fList.Add(new EntityTypeCategory(3, "Μεταφορέας"));
                    fList.Add(new EntityTypeCategory(4, "Λήπτης του Αποστολέα (Πωλητή)"));
                    fList.Add(new EntityTypeCategory(5, "Αποστολέας (Πωλητής)"));
                    fList.Add(new EntityTypeCategory(6, "Λοιπές Συσχετιζόμενες Οντότητες"));
                }

                return fList;
            }
        }
    }
}
