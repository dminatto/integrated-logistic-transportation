using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using sac.application.ViewModels;
using sac.domain.Entities;

namespace sac.application.Interfaces
{
    public interface ITicketAppService : IModelService<TicketViewModel>
    {
        IEnumerable<TicketViewModel> Search(Expression<Func<Ticket, bool>> predicate);
    }
}
