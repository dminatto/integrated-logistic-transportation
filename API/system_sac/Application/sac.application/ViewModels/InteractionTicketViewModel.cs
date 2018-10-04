using System;

namespace sac.application.ViewModels
{
    public class InteractionTicketViewModel
    {
        public int IdTicket { get; set; }
        public DateTime DateInteraction { get; set; }
        public int IdUsuario { get; set; }
        public string NoteTicket { get; set; }
    }
}
