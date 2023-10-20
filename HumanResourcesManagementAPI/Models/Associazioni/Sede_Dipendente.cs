using HumanResourcesManagementAPI.Models.Classi;

namespace HumanResourcesManagementAPI.Models.Associazioni
{
    public class Sede_Dipendente : AggregateRoot
    {
        public Guid DipendenteID { get; set; }
        public virtual Dipendente Dipendente { get; set; }
        public Guid SedeID { get; set; }
        public virtual Sede Sede { get; set; }

    }
}
