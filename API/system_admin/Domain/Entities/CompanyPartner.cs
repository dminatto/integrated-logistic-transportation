using Domain.Entities;

namespace admin.domain.Entities
{
    public enum TypeCompany
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
    };

    public class CompanyPartner : BaseEntity
    {
        public int cnpjCompanyPartner { get; set; }
        public int stateRegistrationCompanyPartner { get; set; }
        public string nameCompanyPartner { get; set; }
        public string emailCompanyPartner { get; set; }
        public int cepCompanyPartner { get; set; }
        public Country countryCompanyPartner { get; set; }
        public State stateCompanyPartner { get; set; }
        public string cityCompanyPartner { get; set; }
        public string aderessCompanyPartner { get; set; }
        public int numberAderessCompanyPartner { get; set; }
        public string complementCompanyPartner { get; set; }
        public string districtCompanyPartner { get; set; }
        public TypeCompany typeCompanyPartner { get; set; }
    }
}
