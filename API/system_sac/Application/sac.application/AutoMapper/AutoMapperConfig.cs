using AutoMapper;
using sac.application.ViewModels;
using sac.domain.Entities;

namespace sac.application.AutoMapper
{
    public class AutoMapperConfig
    {
        public static void RegisterMappings()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Ticket, TicketViewModel>().ReverseMap();
            });
        }
    }
}
