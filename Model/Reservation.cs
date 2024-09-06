using System.ComponentModel.DataAnnotations;

namespace Cafe.Model
{
    public class Reservation
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "Email in not valid")]
        public string Email { get; set; }
        [Required]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "Invalid Phone Number")]
        public string Phone { get; set; }
        [Required]
        public int TotalPeople { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        [DataType(DataType.Time)]
        [RegularExpression(@"^(0[1-9]|1[0-2]):[0-5][0-9] (AM|PM|am|pm)$", ErrorMessage = "Invalid Time. Use hh:mm AM/PM format.")]
        public string Time { get; set; }
    }
}
