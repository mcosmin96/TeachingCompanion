using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeachingCompanion.WebAPI.Models;

namespace TeachingCompanion.WebAPI.Temp
{
    public static class DataManager
    {
        public static List<ChartModel> GetData()
        {
            var r = new Random();
            return new List<ChartModel>()
            {
                new ChartModel() { Data = new List<int>() { r.Next(1, 40) }, Label = "10-20" },
                new ChartModel() { Data = new List<int>() { r.Next(1, 40) }, Label = "20-30" },
                new ChartModel() { Data = new List<int>() { r.Next(1, 40) }, Label = "40-50" },
                new ChartModel() { Data = new List<int>() { r.Next(1, 40) }, Label = "60-90" }
            };
        }
    }
}
