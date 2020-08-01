using Aciertagol.Web.Data.Entities;
using Aciertagol.Web.Models;

namespace Aciertagol.Web.Helpers
{
    public interface IConverterHelper
    {
        TeamEntity ToTeamEntity(TeamViewModel model, string path, bool isNew);

        TeamViewModel ToTeamViewModel(TeamEntity teamEntity);
        TeamEntity ToTeamEntity(TeamViewModel teamViewModel, object path, bool v);
    }
}
