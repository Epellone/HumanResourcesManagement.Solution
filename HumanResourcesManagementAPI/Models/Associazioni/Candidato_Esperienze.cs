using HumanResourcesManagementAPI.Models.Classi;

namespace HumanResourcesManagementAPI.Models.Associazioni
{
    public class Candidato_Esperienze : AggregateRoot
    {
        public Guid EsperienzeLavorativeID { get; set; }
        public virtual EsperienzeLavorative EsperienzeLavorative { get; set; }
        public Guid CandidatoID { get; set; }
        public virtual Candidato Candidato { get; set; }

    }
}
