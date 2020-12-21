﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreUi.Models
{
    public class Rover
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Landing_Date { get; set; }
        public DateTime Launch_Date { get; set; }
        public string Status { get; set; }
    }
}

