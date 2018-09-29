namespace admin.domain.Entities
{
    public class Company
    {
        public int idCompany { get; set; }
        public int cnpjCompany { get; set; }
        public int stateRegistrationCompany { get; set; }
        public string nameCompany { get; set; }
        public string nameFantasy { get; set; }
        public string emailCompany { get; set; }
        public int cepCompany { get; set; }
        public Country countryCompany { get; set; }
        public State stateCompany { get; set; }
        public string cityCompany { get; set; }
        public string aderessCompany { get; set; }
        public int numberAderessCompany { get; set; }
        public string complementCompany { get; set; }
        public string districtCompany { get; set; }
        public string emailAcessCTE { get; set; }
        public string passwordAcessCTE { get; set; }
    }
}
