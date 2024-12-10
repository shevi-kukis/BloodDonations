using System.ComponentModel.DataAnnotations.Schema;

namespace blood_donations.Entities
{
    public class CompatibilityCheck
    {
       
        public int Id { get; private set; }

        public string IdPatient { get; set; }

        public int NumNeedDose { get; set; }

        public string IdBloodeDose { get; set; }
        
        //public DateOnly DateCheck { get; set; }
      
    }
}
