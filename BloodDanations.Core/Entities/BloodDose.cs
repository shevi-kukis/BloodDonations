namespace blood_donations.Entities
{
    public class BloodDose
    {
        private static int id=1;
        public int Id { get; private set; }
        public string IdDonor  { get; set; }
        public string bloodType { get; set; }

        public DateOnly DatOfDonation { get; set; }
        public DateOnly expirationDate { get; set; }

        public bool IsChecked { get; set; }
        public bool IsTaken { get; set; }

        public BloodDose() {
            Id = id;
            id++;
        }


    }
}
