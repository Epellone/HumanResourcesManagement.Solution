using HumanResourcesManagementAPI.Models.Associazioni;

namespace HumanResourcesManagementAPI.Models.Classi
{
    public class Benefits : AggregateRoot
    {
        public string? Descrizione { get; set; }
        public virtual ICollection<BenefitsContratto> BenefitsContratto { get; set; }

    }
}
