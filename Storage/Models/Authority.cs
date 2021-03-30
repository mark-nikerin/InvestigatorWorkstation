using Storage.Interfaces;

namespace Storage.Models
{
    public class Authority : IEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Subdivision { get; set; }
    }
}
