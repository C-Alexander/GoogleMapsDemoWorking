using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoogleMapsDemoWorking.Models.GoogleMapsDemoModels
{
    public class CoordinateModel
    {
        public int ID { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public int SectorView { get; set; }
    }
}
