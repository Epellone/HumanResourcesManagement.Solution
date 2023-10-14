using HumanResourcesManagementAPI.Models.Classi;
using HumanResourcesManagementAPI.Models.Interface;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HumanResourcesManagementAPI.Repository
{
    public class RepositorySede : Repository<Sede>, IRepositorySede
    {
        public RepositorySede(ApplicationDBContext dbcontext) : base(dbcontext)
        {
        }
    }
}
