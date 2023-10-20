using HumanResourcesManagementAPI.Models.Classi;

namespace HumanResourcesManagementAPI.Models.Associazioni
{
    public class TipologiaDocumento : AggregateRoot
    {
        public string? Descrizione { get; set; }
    }
}
