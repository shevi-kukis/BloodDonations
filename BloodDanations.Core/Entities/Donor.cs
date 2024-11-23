

namespace blood_donations.Subjects
{
    public enum Sex {Male,Female }

    public enum HealthFund { Leumit,Macabi,Mehuchdet,Clalit}
    public class Donor
    {
      

        public int Id { get;  set; }
        public string FirstNameDonor { get; set; }
        public string LastNameDonor { get; set; }

        public string ?IdDonor { get; set; }

        public DateOnly BirthDate { get; set; }

        //public Sex ?sex { get; set; }

        //public string ?Origin { get; set; }

        //public HealthFund? healthFund { get; set; }

        //public string ? EmailDonor { get; set; }

        //public string? AddressDonor { get; set; }
      
    }
 

}
