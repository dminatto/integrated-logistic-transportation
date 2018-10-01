namespace admin.domain.Entities
{
    public class Customer : BaseEntity
    {
        public string NameCustomer { get; set; }
        public string EmailCustomer { get; set; }
        public string CpfCustomer { get; set; }
        public int PhoneCustomer { get; set; }
        public int CepCustomer { get; set; }
        //public Country CountryCustomer { get; set; }
        //public State StateCustomer { get; set; }
        public int CountryCustomer { get; set; }
        public int StateCustomer { get; set; }
        public string AderessCustomer { get; set; }
        public string ComplementCustomer { get; set; }
        public int NumberAderessCustomer { get; set; }
        public string CityCustomer { get; set; }
        public string DistrictCustomer { get; set; }
    }
}
