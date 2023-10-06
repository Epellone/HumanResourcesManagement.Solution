using Microsoft.EntityFrameworkCore;

namespace HumanResourcesManagementAPI.Models
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) { }
    
        public DbSet<Benefits> Benefits { get; set; }
        public DbSet<BenefitsContratto> BenefitsContratti { get; set; }
        public DbSet<Candidato> Candidati { get; set; }
        public DbSet<Candidato_Esperienze> CandidatiEsperienze { get; set; }
        public DbSet<Colloquio> Colloqui { get; set; }
        public DbSet<Contratto> Contratti { get; set; }
        public DbSet<Dipendente> Dipendenti { get; set; }
        public DbSet<HardSkill> HardSkills { get; set; }
        public DbSet<HardSkillCandidato> HardSkillsCandidati { get; set; }
        public DbSet<LivelloContrattuale> LivelliContrattuali { get; set; }
        public DbSet<Mansione> Mansioni { get; set; }
        public DbSet<Sede> Sedi { get; set; }
        public DbSet<Sede_Dipendente> SediDipendenti { get; set; }
        public DbSet<SoftSkill> SoftSkills { get; set; }
        public DbSet<SoftSkillCandidato> SoftSkillsCandidati { get; set; }
        public DbSet<TipologiaColloquio> TipologieColloqui { get; set; }
        public DbSet<TipologiaContratto> TipologieContratti { get; set; }
        public DbSet<TipologiaDocumento> TipologieDocumenti { get; set; }
        public DbSet<TitoloDiStudio> TitoliDiStudio { get; set; }
        public DbSet<TitoloDiStudioCandidato> TitoliDiStudioCandidati { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<BenefitsContratto>()
                        .HasKey(bc => bc.Id);       
            
            modelBuilder.Entity<BenefitsContratto>()
                        .HasOne<Contratto>(bc => bc.Contratto)
                        .WithMany(c => c.BenefitsContratto)
                        .HasForeignKey(bc => bc.ContrattoID);

            modelBuilder.Entity<BenefitsContratto>()
                        .HasOne<Benefits>(bc => bc.Benefits)
                        .WithMany(b => b.BenefitsContratto)
                        .HasForeignKey(bc => bc.BenefitsID);

            modelBuilder.Entity<Candidato>()
                        .HasOne(c => c.Colloquio)
                        .WithOne(cq => cq.Candidato)
                        .HasForeignKey<Colloquio>(cq => cq.CandidatoID);

            modelBuilder.Entity<Colloquio>()
                        .HasOne(cl => cl.Sede)
                        .WithOne()
                        .HasForeignKey<Colloquio>(cl => cl.SedeColloquioID)
                        .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Sede_Dipendente>()
                        .HasOne(s => s.Sede)
                        .WithMany(sd => sd.SedeDipendente)
                        .HasForeignKey(s => s.SedeID)
                        .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Sede_Dipendente>()
                        .HasOne(d => d.Dipendente)
                        .WithOne()
                        .HasForeignKey<Sede_Dipendente>(d => d.DipendenteID)
                        .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
