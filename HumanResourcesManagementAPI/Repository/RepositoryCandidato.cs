using HumanResourcesManagementAPI.Models.Classi;
using HumanResourcesManagementAPI.Models.Interface;

namespace HumanResourcesManagementAPI.Repository
{
    public class RepositoryCandidato : Repository<Candidato>, IRepositoryCandidato
    {
        public RepositoryCandidato(ApplicationDBContext dbcontext) : base(dbcontext)
        {
        }
    }
}
