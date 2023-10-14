using HumanResourcesManagementAPI.Models.Associazioni;

namespace HumanResourcesManagementAPI.Models.Classi
{
    public class Contratto : AggregateRoot
    {
        public Guid MansioneID { get; set; }
        public virtual Mansione Mansione { get; set; }
        public Guid LivelloContrattualeID { get; set; }
        public virtual LivelloContrattuale LivelloContrattuale { get; set; }
        public Guid TipoContrattoID { get; set; }
        public virtual TipologiaContratto TipologiaContratto { get; set; }
        public Guid TipologiaDocumentoID { get; set; }
        public virtual TipologiaDocumento TipologiaDocumento { get; set; }

        public virtual ICollection<BenefitsContratto> BenefitsContratto { get; set; }
    }
}
