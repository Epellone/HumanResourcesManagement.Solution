using System.ComponentModel.DataAnnotations;

namespace HumanResourcesManagementAPI.Models
{
    public class Sede : AggregateRoot
    {
        // fk + tabella associativa con ref e dip 
        public string Descrizione { get; set; }
        public string Indirizzo { get; set; }
        [RegularExpression(@"^\+?[0-9]{1,3}(-| )?[0-9]{6,15}$")]
        public string RecapitoTel { get; set; }
        [EmailAddress(ErrorMessage = "Campo non valido")]
        public string EmailSede { get; set; }
        
        public Guid IDReferente { get; set; } //FK del referente della sede
        public virtual ICollection<Sede_Dipendente> SedeDipendente { get; set; }
        // lista dei dipendenti che lavorano nella sede 

        //public Sede(string descrizione, string indirizzo, string recapitoTel, string emailSede, Guid idReferente)
        //{
        //    Descrizione = descrizione;
        //    Indirizzo = indirizzo;
        //    RecapitoTel = recapitoTel;
        //    EmailSede = emailSede;
        //    IDReferente = idReferente;
        //    SedeDipendente = new List<Sede_Dipendente>();
        //}
    }
}
