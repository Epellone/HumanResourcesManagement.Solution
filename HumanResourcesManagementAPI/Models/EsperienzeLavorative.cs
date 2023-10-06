using System.ComponentModel.DataAnnotations;

namespace HumanResourcesManagementAPI.Models
{
    public class EsperienzeLavorative : AggregateRoot
    {
        public DateTime DataInizio {  get; set; }
        public DateTime DataFine { get; set; }
        public string Azienda { get; set; }

        [MaxLength(1000)]
        public string Descrizione { get; set; }

    }
}
