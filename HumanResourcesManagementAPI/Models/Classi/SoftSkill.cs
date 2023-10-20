using HumanResourcesManagementAPI.Models.Associazioni;

namespace HumanResourcesManagementAPI.Models.Classi
{
    public class SoftSkill : AggregateRoot
    {
        public string? Descrizione { get; set; }
        public virtual ICollection<SoftSkillCandidato> SoftSkillsCandidato { get; set; }
    }
}
