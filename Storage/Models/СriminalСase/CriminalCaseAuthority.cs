namespace Storage.Models
{
    using Storage.Interfaces;
    using System.Collections.Generic;

    public class CriminalCaseAuthority : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<CriminalCase> CriminalCases { get; set; } = new HashSet<CriminalCase>();

    }
}
