using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace blood_donations.Entities
{
    public class CompatibilityCheck
    {
        [Key]
        public int Id { get; private set; }

        public int PatientId { get; set; }
       
        public Patient patient { get; set; }

        public int NumNeedDose { get; set; }

        public int BloodeDoseId { get; set; }
        
        public BloodDose bloodDose { get; set; }
        //public DateOnly DateCheck { get; set; }

    }
}
