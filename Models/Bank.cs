namespace ProductManagementApp.Models
{
    public class Bank
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? AddressText { get; set; }
        public string Bik { get; set; } = string.Empty;
    }
}
