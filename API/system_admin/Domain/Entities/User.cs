
namespace admin.domain.Entities
{
    public class User
    {
        public int idUser { get; set; }
        public string nameUser { get; set; }
        public string passwordUser { get; set; }
        public UserProfile userProfile { get; set; }
    }
}
