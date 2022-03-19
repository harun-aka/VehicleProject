using Core.Entities;

namespace Entities.DTOs
{
    public class BoatDto : IDto
    {
        public int Id { get; set; }
        public string ColorName { get; set; }
    }
}
