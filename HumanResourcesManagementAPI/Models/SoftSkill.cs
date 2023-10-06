namespace HumanResourcesManagementAPI.Models
{
    public class SoftSkill : AggregateRoot
    {
        public string Descrizione { get; set; }
        public virtual ICollection<SoftSkillCandidato> SoftSkillsCandidato { get; set; }
    }
}
