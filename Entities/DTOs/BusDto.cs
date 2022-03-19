using Core.Entities;

namespace Entities.DTOs
{
    public class BusDto : IDto
    {
        public int Id { get; set; }
        public string ColorName { get; set; }
    }
}
