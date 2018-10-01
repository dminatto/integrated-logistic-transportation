namespace delivery.logistics.domain.Dto
{
    public class ReceivingAddress
    { 
        public int Id { get; set; }
        public int IdDweller { get; set; }
        public string Address { get; set; }
        public int AddressNumber { get; set; }
        public int IdCity { get; set; }
        public int IdState { get; set; }
        public int IdCountry { get; set; }
        public int Cep { get; set; }
        public string District { get; set; }
    }
}
