using System.ComponentModel.DataAnnotations;
namespace ProductManagementApp.Models

{
    public class Bank
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; } = string.Empty;
        public string? AddressText { get; set; }

        [Required(ErrorMessage = "Bik is required")]
        public string Bik { get; set; } = string.Empty;
    }
}
