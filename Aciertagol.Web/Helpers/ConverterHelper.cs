using Aciertagol.Web.Data.Entities;
using Aciertagol.Web.Helpers;
using Aciertagol.Web.Models;

namespace Soccer.Web.Helpers
{
    public class ConverterHelper : IConverterHelper
    {
        public TeamEntity ToTeamEntity(TeamViewModel model, string path, bool isNew)
        {
            return new TeamEntity
            {
                Id = isNew ? 0 : model.Id,
                LogoPath = path,
                Name = model.Name
            };
        }

        public TeamEntity ToTeamEntity(TeamViewModel teamViewModel, object path, bool v)
        {
            throw new System.NotImplementedException();
        }

        public TeamViewModel ToTeamViewModel(TeamEntity teamEntity)
        {
            return new TeamViewModel
            {
                Id = teamEntity.Id,
                LogoPath = teamEntity.LogoPath,
                Name = teamEntity.Name
            };
        }
    }
}
