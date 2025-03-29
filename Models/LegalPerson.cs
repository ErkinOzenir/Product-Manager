using System.ComponentModel.DataAnnotations;

namespace ProductManagementApp.Models
{
    public class LegalPerson
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "INN is required")]
        [Range(100000000, 99999999999999, ErrorMessage = "INN must be between 9 and 14 digits long")]
        public ulong Inn { get; set; }
        public bool? IsResident { get; set; }

        [Required(ErrorMessage = "Full name is required")]
        public string FullName { get; set; } = string.Empty;
    }
}
