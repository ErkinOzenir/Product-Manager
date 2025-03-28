namespace ProductManagementApp.Models
{
    public class LegalPerson
    {
        public int Id { get; set; }
        public string Inn { get; set; } = string.Empty;
        public bool? IsResident { get; set; }
        public string FullName { get; set; } = string.Empty;
    }
}
