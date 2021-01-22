namespace Parks.Models
{
    public class NationalPark
    {
        public int Id { get; set; }
        public string Name { get; set; }
		public string Location { get; set; }
		public string DateEstablished { get; set; }
		public string Acres { get; set; }
		public string YearlyVisitors { get; set; }
        public string Description { get; set; }
    }
}