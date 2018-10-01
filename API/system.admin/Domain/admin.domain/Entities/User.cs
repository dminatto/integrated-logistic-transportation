namespace admin.domain.Entities
{
    public class User : BaseEntity
    {
        public string NameUser { get; set; }
        public string PasswordUser { get; set; }
        //public UserProfile UserProfile { get; set; }
        public int UserProfile { get; set; }
    }
}
