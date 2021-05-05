namespace Services.DTOs.Employee
{ 

    using Storage.Models;

    public class RankDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Term { get; set; }

        public static explicit operator RankDTO(Rank entity)
        {
            if (entity is null)
            {
                return null;
            }

            return new RankDTO
            {
                Id = entity.Id,
                Name = entity.Name,
                Term = entity.Term
            };
        }
    }
}
