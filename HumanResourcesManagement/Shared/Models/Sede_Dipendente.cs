namespace HumanResourcesManagementAPI.Models
{
    public class Sede_Dipendente : AggregateRoot
    {
        public Guid DipendenteID { get; set; }
        public virtual Dipendente Dipendente { get; set; }
        public Guid SedeID { get; set; }
        public virtual Sede Sede { get; set; }
        
    }
}
