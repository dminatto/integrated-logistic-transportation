namespace admin.domain.Entities
{
    public enum ModulePermission
    {
        ACTIVE = 0,
        INACTIVE = 1
    }

    public enum SystemModule
    {
        ADMINISTRATIVE = 1,
        SHIPMENT = 2,
        FREIGHT_TABLES = 3,
        DELIVERY_LOGISTICS = 4,
        EXPEDITION = 5,
        RETURN_REMAND_LOSS = 6,
        ELECTRONIC_KNOWLEDGE = 7,
        SAC = 8,
        INTEGRATION = 9
    }

    public class UserPermissions : BaseEntity
    {
        public int IdUser { get; set; }
        public int IdModule { get; set; }
        public int Permission { get; set; }
    }
}
