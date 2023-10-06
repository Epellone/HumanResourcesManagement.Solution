namespace HumanResourcesManagementAPI.Models
{
    public class SoftSkillCandidato : AggregateRoot
    {
        public Guid CandidatoID { get; set; }
        public virtual Candidato Candidato { get; set; }
        public Guid SoftSkillID { get; set; } 
        public virtual SoftSkill SoftSkill { get; set; }
        public string Descrizione { get; set; }
    }
}
