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
        public int CnpjCompanyPartner { get; set; }
        public string NameCompanyPartner { get; set; }
        public string EmailCompanyPartner { get; set; }
        public int AderessCompanyPartner { get; set; }
        public int TypeCompanyPartner { get; set; }
    }
}
