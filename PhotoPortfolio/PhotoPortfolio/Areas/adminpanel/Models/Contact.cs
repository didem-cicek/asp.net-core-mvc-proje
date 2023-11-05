namespace PhotoPortfolio.Areas.adminpanel.Models
{
    public class Contact : Base
    {
        public string AddressTitle { get; set; }
        public string Address { get; set; }
        public string EmailTitle { get; set; }
        public string Email { get; set; }
        public string PhoneTitle { get; set; }
        public string Phone { get; set; }

        public int PagesId { get; set; }
        public Pages Pages { get; set; }

    }
}
