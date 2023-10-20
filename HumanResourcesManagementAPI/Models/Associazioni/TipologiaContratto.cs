using HumanResourcesManagementAPI.Models.Classi;

namespace HumanResourcesManagementAPI.Models.Associazioni
{
    public class TipologiaContratto : AggregateRoot
    {
        public string? Descrizione { get; set; }
    }
}
