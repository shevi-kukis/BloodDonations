using blood_donations.Subjects;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace blood_donations.Entities
{
    public class BloodDose
    {

        [Key]
        public int Id { get; private set; }
       
        public string bloodType { get; set; }
       
        //public DateOnly DatOfDonation { get; set; }
       
        //public DateOnly expirationDate { get; set; }

        public bool IsChecked { get; set; }
        public bool IsTaken { get; set; }

        public int DonorId { get; set; }

        public Donor donor { get; set; }

        public List<CompatibilityCheck> compatibilityChecks { get; set; }
    }
}
