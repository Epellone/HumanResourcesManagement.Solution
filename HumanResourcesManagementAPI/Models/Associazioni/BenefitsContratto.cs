using HumanResourcesManagementAPI.Models.Classi;

namespace HumanResourcesManagementAPI.Models.Associazioni

{
    public class BenefitsContratto : AggregateRoot
    {
        public Guid ContrattoID { get; set; }
        public virtual Contratto Contratto { get; set; }
        public Guid BenefitsID { get; set; }
        public virtual Benefits Benefits { get; set; }
    }
}
