using System.ComponentModel.DataAnnotations;

namespace HumanResourcesManagementAPI.Models
{
    public class Colloquio : AggregateRoot
    {
        public DateTime DataColloquio { get; set; }
        public Guid SedeColloquioID { get; set; }
        public virtual Sede Sede { get; set; }
        public Guid DipendenteColloquioID { get; set; }
        public virtual Dipendente Dipendente { get; set; }
        public Guid TipologiaColloquioID { get; set; }
        public virtual TipologiaColloquio TipologiaColloquio { get; set; }
        public Guid CandidatoID { get; set; }
        public virtual Candidato Candidato { get; set; }
        [MaxLength(1000)]
        public string? Note { get; set; }
    }
}
