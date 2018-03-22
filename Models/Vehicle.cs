using System;
using System.Collections.Generic;

namespace StarWarsRPG.Models
{
    public partial class Vehicle
    {
        public int VehicleId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? VehicleTypeId { get; set; }
        public decimal? Encumberance { get; set; }
        public int? SensorTypeId { get; set; }
        public int? AltitudeLimit { get; set; }
        public int? PassengerCapacity { get; set; }
        public int? Cost { get; set; }
        public int? RarityId { get; set; }
        public int? HardPoints { get; set; }
        public int? Silhouette { get; set; }
        public int? Speed { get; set; }
        public int? Handling { get; set; }
        public int? DefenseBow { get; set; }
        public int? DefenseAft { get; set; }
        public int? DefensePort { get; set; }
        public int? DefenseStarport { get; set; }
        public int? Armor { get; set; }
        public int? TraumaThreshold { get; set; }
        public int? StrainThreshold { get; set; }
        public bool? Navicomputer { get; set; }
        public string Consumables { get; set; }
        public int? HyperdrivePrimaryId { get; set; }
        public int? HyperdriveBackupId { get; set; }
        public bool? Restricted { get; set; }
        public string HullType { get; set; }
        public string Class { get; set; }
        public int? ManufacturerId { get; set; }
        public bool? DroidSocket { get; set; }
    }
}
