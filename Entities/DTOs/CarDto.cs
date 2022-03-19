using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class CarDto : IDto
    {
        public int Id { get; set; }
        public int Wheel { get; set; }
        public bool HeadLights { get; set; }
        public string ColorName { get; set; }
    }
}
