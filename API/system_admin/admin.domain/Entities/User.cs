using Domain.Entities;

namespace admin.domain.Entities
{
    public class User : BaseEntity
    {
        public string nameUser { get; set; }
        public string passwordUser { get; set; }
        //public UserProfile userProfile { get; set; }
        public int userProfile { get; set; }
    }
}
