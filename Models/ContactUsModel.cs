using System.ComponentModel.DataAnnotations;

namespace WeeBtpWebsite.Models
{
    public class ContactUsModel
    {
        [Required]
        public string firstName { set; get; }
        [EmailAddress]
        public string email { set; get; }
        [Phone]
        public string phoneNumber { set; get; }
        public string Subject { set; get; }
        public string Message { set; get; }
    }
}
