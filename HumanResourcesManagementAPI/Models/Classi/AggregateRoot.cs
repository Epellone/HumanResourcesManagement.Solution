namespace HumanResourcesManagementAPI.Models.Classi
{
    public class AggregateRoot
    {
        public Guid Id { get; set; }
        public int Version { get; set; }
        public bool Attivo { get; set; }
        public AggregateRoot() //costruttore
        {
            Id = Guid.NewGuid();
        }
    }
}
