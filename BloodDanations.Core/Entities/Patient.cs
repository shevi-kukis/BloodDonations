namespace blood_donations.Entities
{
    public enum Sex1 { Male, Female }

    public enum HealthFund1 { Leumit, Macabi, Mehuchdet, Clalit }

    public enum LevelOfUrgency1 { mostUrgent, Urgent, NotUrgent }
    public class Patient
    {
        public int Id { get; set; }
        public string FirstNamePatient { get; set; }
        public string LastNamePatient { get; set; }


        public string IdPatient { get; set; }

        public Sex1 sex { get; set; }

        public string Origin { get; set; }

        public HealthFund1 healthFund { get; set; }

        public string AddressPatient { get; set; }

        public LevelOfUrgency1 levelOfUrgency { get; set; }

        public string bloodType { get; set; }

        public string IdEmployee { get; set; }

        //public DateOnly BirthDate { get; set; }

    }
}
