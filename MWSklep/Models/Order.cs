using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.ComponentModel;

namespace MWSklep.Models
{
    public class Order
    {
        public int OrderId { get; set; }

        public System.DateTime OrderDate { get; set; }

        public string Username { get; set; }

        [Required(ErrorMessage = "Imię jest wymagane")]
        [DisplayName("Imię")]
        [StringLength(160)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Nazwisko jest wymagane")]
        [DisplayName("Nazwisko")]
        [StringLength(160)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Adres jest wymagany")]
        [StringLength(70)]
        public string Address { get; set; }

        [Required(ErrorMessage = "Miasto jest wymagane")]
        [StringLength(40)]
        public string City { get; set; }

        [Required(ErrorMessage = "Województwo jest wymagane")]
        [StringLength(40)]
        public string State { get; set; }

        [Required(ErrorMessage = "Kod pocztowy jest wymagany")]
        [DisplayName("Kod pocztowy")]
        [StringLength(10)]
        public string PostalCode { get; set; }

        [Required(ErrorMessage = "Kraj jest wymagany")]
        [StringLength(40)]
        public string Country { get; set; }

        [StringLength(24)]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Adres Email jest wymagany")]
        [DisplayName("Adres Email")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}",
            ErrorMessage = "Email nie spełnia warunków.")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [ScaffoldColumn(false)]
        public decimal Total { get; set; }

        [ScaffoldColumn(false)]
        public string PaymentTransactionId { get; set; }

        [ScaffoldColumn(false)]
        public bool HasBeenShipped { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }
    }
}