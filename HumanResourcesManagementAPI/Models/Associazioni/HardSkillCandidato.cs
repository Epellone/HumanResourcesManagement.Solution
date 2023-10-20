using HumanResourcesManagementAPI.Models.Classi;

namespace HumanResourcesManagementAPI.Models.Associazioni
{
    public class HardSkillCandidato : AggregateRoot
    {
        public Guid CandidatoID { get; set; }
        public virtual Candidato Candidato { get; set; }
        public Guid HardSkillID { get; set; }
        public virtual HardSkill HardSkill { get; set; }
        public string? Descrizione { get; set; }
    }
}
