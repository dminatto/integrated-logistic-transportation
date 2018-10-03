namespace admin.domain.Dto
{
    public class Billing
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime DateBilling { get; set; }
        public decimal GrossValue { get; set; }
        public decimal NetValue { get; set; }
        public decimal TaxAmount { get; set; }
    }
}
