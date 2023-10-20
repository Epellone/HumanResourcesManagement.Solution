using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace HumanResourcesManagementAPI.Models
{
    public class Candidato : AggregateRoot
    {
        [RegularExpression(@"[A-Za-z\s]*$")]
        public string? Nome { get; set; }
        [RegularExpression(@"[A-Za-z\s']*$")]
        public string? Cognome { get; set; }
        public string? RecapitoTelefonico { get; set; }
        [RegularExpression(@"[A-Z]{6}\d{2}[A-Z]\d{2}[A-Z]\d{3}[A-Z]$", ErrorMessage = "Campo non valido")]
        public string? CF { get; set; }

        [EmailAddress(ErrorMessage = "Campo non valido")] 
        public string? Email { get; set; }
        public string? Comune { get; set; }
        public string? Provincia { get; set; }
        public DateTime DataDiNascita { get; set; }
        public Guid ColloquioID { get; set; }
        public Colloquio? Colloquio { get; set; }
        public virtual ICollection<HardSkillCandidato> HardSkillsCandidato { get; set; }
        public virtual ICollection<SoftSkill> SoftSkillsCandidato { get; set; }
        public virtual ICollection<TitoloDiStudio> TitoliDiStudioCandidato { get; set; }
    }
}
