using Storage.Models;

namespace Services.DTOs
{
    public class AuthorityDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Subdivision { get; set; }

        public static explicit operator AuthorityDTO(Authority entity)
        {
            if (entity is null)
            {
                return null;
            }

            return new AuthorityDTO
            {
                Id = entity.Id,
                Title = entity.Title,
                Address = entity.Address,
                PhoneNumber = entity.PhoneNumber,
                Subdivision = entity.Subdivision
            };
        }
    }
}
