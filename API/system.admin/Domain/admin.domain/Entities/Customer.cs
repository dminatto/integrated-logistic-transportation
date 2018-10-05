namespace admin.domain.Entities
{
    public class Customer : BaseEntity
    {
        public string NameCustomer { get; set; }
        public string EmailCustomer { get; set; }
        public string CpfCustomer { get; set; }
        public int PhoneCustomer { get; set; }
        public int CepCustomer { get; set; }
        public int AddressCustomer { get; set; }
    }
}
