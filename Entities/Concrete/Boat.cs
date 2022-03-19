using Core.Entities;
using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Boat: Vehicle, IEntity
    {
        public int Id { get; set; }
    }
}
