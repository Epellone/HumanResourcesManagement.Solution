namespace HumanResourcesManagementAPI.Models
{
    public class TitoloDiStudioCandidato : AggregateRoot
    {
        public Guid CandidatoID { get; set; }
        public virtual Candidato Candidato { get; set; }
        public Guid TitoloDiStudioID { get; set; } // proprietà di navigazione quando scriviamo così(doppia riga) 
        public virtual TitoloDiStudio TitoloDiStudio { get; set; }
    }
}
