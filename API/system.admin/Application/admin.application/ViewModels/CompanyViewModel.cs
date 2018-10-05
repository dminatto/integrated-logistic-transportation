namespace admin.application.ViewModels
{
    public class CompanyViewModel : BaseViewModel
    {
        public int CnpjCompany { get; set; }
        public string NameCompany { get; set; }
        public string NameFantasy { get; set; }
        public string EmailCompany { get; set; }
        public int AddressCompany { get; set; }
        public string EmailAcessCTE { get; set; }
        public string PasswordAcessCTE { get; set; }
    }
}
