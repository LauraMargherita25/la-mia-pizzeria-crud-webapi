using la_mia_pizzeria_static.Validetors;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace la_mia_pizzeria_static.Models
{
    [Table("messages")]
    public class Message
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Il campo è obbligatorio")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Il campo è obbligatorio")]
        public string LastName { get; set; }

        [EmailAddress]
        [Required(ErrorMessage = "Il campo è obbligatorio")]
        public string Email { get; set; }

        public int? PhoneNumber { get; set; }

        [Required(ErrorMessage = "Il campo è obbligatorio")]
        public string Title { get; set; }

        [TextLengthAttribute]
        [Required(ErrorMessage = "Il campo è obbligatorio")]
        public string Body { get; set; }

        public Message()
        {

        }

        public Message (string name, string lastName, string email, int? phoneNumber, string title, string body)
        {
            Name = name;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
            Title = title;
            Body = body;
        }
    }
}
