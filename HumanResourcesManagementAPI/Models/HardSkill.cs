namespace HumanResourcesManagementAPI.Models
{
    public class HardSkill : AggregateRoot
    {
        public string Descrizione { get; set; }
        public virtual ICollection<HardSkillCandidato> HardSkillsCandidato { get; set; }
    }
}
