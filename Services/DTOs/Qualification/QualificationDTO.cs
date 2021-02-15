namespace Services.DTOs.Qualification
{
    public class QualificationDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public static explicit operator QualificationDTO(Storage.Models.Qualification entity)
        {
            return new QualificationDTO
            {
                Id = entity.Id,
                Name = entity.Name
            };
        }
    }
}
