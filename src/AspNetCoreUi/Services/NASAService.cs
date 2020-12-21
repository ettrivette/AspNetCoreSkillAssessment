using AspNetCoreUi.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace AspNetCoreUi.Services
{
    public class NASAService
        : INASAService
    {
        public async Task<IEnumerable<RoverPhoto>> GetRoverImages(string Camera, int Sol)
        {
            //Task: Write an API call to fetch the NASA rover images
            //API Key: 1P3xQ5eOLdLp0YlenTqnlT6FuIBXCPDi4J1IKCcX
            //The URL to call (GET) is https://api.nasa.gov/mars-photos/api/v1/rovers/curiosity/photos?sol={SOL}&camera={CAMERA}&api_key={APIKEY}
            //The API returns JSON and can be deserialized as an instance of "GetRoverPhotoResults"
            throw new NotImplementedException();
        }
    }
}
