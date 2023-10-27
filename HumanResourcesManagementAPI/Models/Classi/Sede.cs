using System.ComponentModel.DataAnnotations;
using HumanResourcesManagementAPI.Models.Associazioni;

namespace HumanResourcesManagementAPI.Models.Classi
{
    public class Sede : AggregateRoot
    {
        // fk + tabella associativa con ref e dip 
        public string? Descrizione { get; set; }
        public string? Indirizzo { get; set; }
        [RegularExpression(@"^\+?[0-9]{1,3}(-| )?[0-9]{6,15}$")]
        public string? RecapitoTel { get; set; }
        [EmailAddress(ErrorMessage = "Campo non valido")]
        public string? EmailSede { get; set; }

        public virtual ICollection<Sede_Dipendente>? SedeDipendente { get; set; }

        // public Sede (Guid Sede, string indirizzo, string RecapitoTel, string EmailSede);

    }
}


