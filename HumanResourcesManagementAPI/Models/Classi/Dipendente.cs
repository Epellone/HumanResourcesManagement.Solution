using System.ComponentModel.DataAnnotations;
using System.Data;
using HumanResourcesManagementAPI.Models.Associazioni;

namespace HumanResourcesManagementAPI.Models.Classi
{
    public class Dipendente : AggregateRoot
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }

        [RegularExpression(@"[A-Z]{6}\d{2}[A-Z]\d{2}[A-Z]\d{3}[A-Z]$", ErrorMessage = "Campo non valido")]
        public string CF { get; set; }
        //public Guid SedeID { get; set; }
        //public virtual Sede Sede { get; set; }
        //      public Guid ContrattoID { get; set; }
        //    public virtual Contratto Contratto { get; set; }
        public Guid MansioneID { get; set; }
        public virtual Mansione Mansione { get; set; }
        public virtual ICollection<Sede_Dipendente> SedeDipendente { get; set; }


    }
}
