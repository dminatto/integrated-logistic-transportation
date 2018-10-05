﻿namespace admin.application.ViewModels
{
    public class AddressViewModel : BaseViewModel
    {
        public int IdCountry { get; set; }
        public int IdState { get; set; }
        public string Dwelling { get; set; }
        public string Complement { get; set; }
        public int Number { get; set; }
        public int City { get; set; }
        public string District { get; set; }
        public int Cep { get; set; }
    }
}
