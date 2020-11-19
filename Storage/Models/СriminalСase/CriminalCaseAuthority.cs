namespace Storage.Models
{
    using Storage.Interfaces;

    public class CriminalCaseAuthority : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
