using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewProj.Models
{
    public class CarModel
    {
        public int Car_id { get; set; }

        public string Car_marca { get; set; }

        public string Car_model { get; set; }

        public int Car_price { get; set; }

        public string Car_image { get; set; }
        public int Car_an { get; set; }
        public int Car_km { get; set; }
        public string Car_cutie { get; set; }
        public string Car_culoare { get; set; }
    }
}