namespace HumanResourcesManagementAPI.Models
{
    public class Benefits : AggregateRoot  
    {
        public string? Descrizione { get; set; }
        public virtual ICollection <BenefitsContratto> BenefitsContratto { get; set; }

    }
}
