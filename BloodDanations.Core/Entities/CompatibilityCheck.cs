namespace blood_donations.Entities
{
    public class CompatibilityCheck
    {
        private static int id = 1;
        public int Id { get; private set; }

        public string IdPatient { get; set; }

        public int NumNeedDose { get; set; }

        public string IdBloodeDose { get; set; }

        public DateOnly DateCheck { get; set; }
        public CompatibilityCheck() { 

            Id = id;
            id++;
        } 
    }
}
