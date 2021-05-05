using Storage.Models;

namespace Services.DTOs.Employee
{
    public class PositionDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public static explicit operator PositionDTO(Position entity)
        {
            if (entity is null)
            {
                return null;
            }

            return new PositionDTO
            {
                Id = entity.Id,
                Name = entity.Name
            };
        }
    }
}