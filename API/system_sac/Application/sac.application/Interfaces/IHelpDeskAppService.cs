using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using sac.application.ViewModels;
using sac.domain.Entities;

namespace sac.application.Interfaces
{
    public interface IHelpDeskAppService : IModelService<HelpDeskViewModel>
    {
        IEnumerable<HelpDeskViewModel> Search(Expression<Func<HelpDesk, bool>> predicate);
    }
}
