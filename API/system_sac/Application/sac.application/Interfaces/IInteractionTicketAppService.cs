using sac.application.ViewModels;
using sac.domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace sac.application.Interfaces
{
    public interface IInteractionTicketAppService : IModelService<InteractionTicketViewModel>
    {
        IEnumerable<InteractionTicketViewModel> Search(Expression<Func<InteractionTicket, bool>> predicate);
    }
}
