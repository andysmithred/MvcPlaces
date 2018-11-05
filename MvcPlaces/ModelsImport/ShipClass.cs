using System;
using System.Collections.Generic;

namespace MvcPlaces.ModelsImport
{
    public partial class ShipClass
    {
        public ShipClass()
        {
            InversePreceded = new HashSet<ShipClass>();
            InverseSucceeded = new HashSet<ShipClass>();
            Ship = new HashSet<Ship>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? PrecededId { get; set; }
        public int? SucceededId { get; set; }
        public int TypeId { get; set; }
        public int? Displacement { get; set; }
        public double? Length { get; set; }
        public double? Beam { get; set; }
        public int? Propulsion { get; set; }
        public double? Speed { get; set; }
        public int? Crew { get; set; }

        public ShipClass Preceded { get; set; }
        public ShipClass Succeeded { get; set; }
        public ShipType Type { get; set; }
        public ICollection<ShipClass> InversePreceded { get; set; }
        public ICollection<ShipClass> InverseSucceeded { get; set; }
        public ICollection<Ship> Ship { get; set; }
    }
}
