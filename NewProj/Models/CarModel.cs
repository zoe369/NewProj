using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewProj.Models
{
    public class CarModel
    {
        public int ID { get; set; }
        public string Marca { get; set; }
        public string Model { get; set; }
        public int Pret { get; set; }
        public int An_fabricatie { get; set; }
        public int Km { get; set; }
        public string Culoare { get; set; }
        public string Cutie { get; set; }
        public string Image { get; set; }
    }
}