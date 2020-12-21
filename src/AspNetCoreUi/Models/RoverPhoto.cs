using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreUi.Models
{
    public class RoverPhoto
    {
        public int Id { get; set; }
        public int Sol { get; set; }
        public string Img_Src { get; set; }
        public DateTime Earth_Date { get; set; }
        public Rover Rover { get; set; }
    }
}

