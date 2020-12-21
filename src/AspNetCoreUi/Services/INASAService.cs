﻿using AspNetCoreUi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace AspNetCoreUi.Services
{
    public interface INASAService
    {
        Task<IEnumerable<RoverPhoto>> GetRoverImages(string Camera, int Sol);
    }
}
