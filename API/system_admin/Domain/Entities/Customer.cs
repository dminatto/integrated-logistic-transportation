
namespace admin.domain.Entities
{
    public class Customer
    {
        public int idCustomer { get; set; }
        public string nameCustomer { get; set; }
        public string emailCustomer { get; set; }
        public string cpfCustomer { get; set; }
        public int phoneCustomer { get; set; }
        public Country countryCustomer { get; set; }
        public State stateCustomer { get; set; }
        public string aderessCustomer { get; set; }
        public string complementCustomer { get; set; }
        public int numberAderessCustomer { get; set; }
        public string cityCustomer { get; set; }
        public string districtCustomer { get; set; }
    }
}
