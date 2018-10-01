namespace admin.domain.Entities
{
    public class Company : BaseEntity
    {
        public int CnpjCompany { get; set; }
        public int StateRegistrationCompany { get; set; }
        public string NameCompany { get; set; }
        public string NameFantasy { get; set; }
        public string EmailCompany { get; set; }
        public int CepCompany { get; set; }
        //public Country countryCompany { get; set; }
        //public State stateCompany { get; set; }
        public int CountryCompany { get; set; }
        public int StateCompany { get; set; }
        public string CityCompany { get; set; }
        public string AderessCompany { get; set; }
        public int NumberAderessCompany { get; set; }
        public string ComplementCompany { get; set; }
        public string DistrictCompany { get; set; }
        public string EmailAcessCTE { get; set; }
        public string PasswordAcessCTE { get; set; }
    }
}
