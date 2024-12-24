

using blood_donations.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace blood_donations.Subjects
{
    public enum Sex {Male,Female }

    public enum HealthFund { Leumit,Macabi,Mehuchdet,Clalit}
    public class Donor
    {

        [Key]
        public int Id { get;  set; }
        public string FirstNameDonor { get; set; }
        public string LastNameDonor { get; set; }

        public string Tz { get; set; }
      
        //public DateTime BirthDate { get; set; }

        public Sex ?sex { get; set; }

        public string ?Origin { get; set; }

       public HealthFund? healthFund { get; set; }

        public string ? EmailDonor { get; set; }

        public string? AddressDonor { get; set; }

        public List<BloodDose> BloodDoses { get; set; }

    }


}
