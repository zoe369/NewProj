using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewProj.Models
{
    public class CarsssModel
    {
        public List<Car> Cars { get; set; }
        public int CurrentPageIndex { get; set; }
        public int PageCount { get; set; }
    }
}