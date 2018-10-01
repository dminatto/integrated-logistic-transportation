namespace admin.domain.Entities
{
    /*public enum TypeCompany
    {
        AUTONOMOUS = 1,
        COMMERCE = 2,
        COMMUNICATION = 3,
        ENERGY = 4,
        INDUSTRY = 5,
        RURAL_PRODUCER = 6,
        SERVICE = 7,
        TRANSPORT = 8,
        OTHERS = 9
    };*/
    public class CompanyPartner : BaseEntity
    {
        public int CnpjCompanyPartner { get; set; }
        public int StateRegistrationCompanyPartner { get; set; }
        public string NameCompanyPartner { get; set; }
        public string EmailCompanyPartner { get; set; }
        public int CepCompanyPartner { get; set; }
        //public Country countryCompanyPartner { get; set; }
        //public State stateCompanyPartner { get; set; }
        public int CountryCompanyPartner { get; set; }
        public int StateCompanyPartner { get; set; }
        public string CityCompanyPartner { get; set; }
        public string AderessCompanyPartner { get; set; }
        public int NumberAderessCompanyPartner { get; set; }
        public string ComplementCompanyPartner { get; set; }
        public string DistrictCompanyPartner { get; set; }
        //public TypeCompany typeCompanyPartner { get; set; }
        public int TypeCompanyPartner { get; set; }
    }
}
