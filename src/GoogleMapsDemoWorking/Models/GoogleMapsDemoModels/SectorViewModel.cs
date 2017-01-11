using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoogleMapsDemoWorking.Models.GoogleMapsDemoModels
{
    public class SectorViewModel
    {
        public int ID { get; set; }
        public List<CoordinateModel> Coordinates { get; set; }
        public bool Blocked { get; set; }
    }
}
