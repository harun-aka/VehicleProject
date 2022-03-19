using Core.Entities;
using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Car: Vehicle, IEntity
    {
        public int Id { get; set; }
        public int Wheel { get; set; }
        public bool HeadLights { get; set; }
    }
}
