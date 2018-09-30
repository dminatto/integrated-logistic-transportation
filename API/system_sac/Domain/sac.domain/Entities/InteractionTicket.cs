namespace sac.domain.Entities
{
    public class InteractionTicket : BaseEntity
    {
        public int IdTicket { get; set; }
        public int IdUsuario { get; set; }
        public string NoteTicket { get; set; }
    }
}
