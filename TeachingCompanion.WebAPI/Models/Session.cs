﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeachingCompanion.WebAPI.Models
{
    public class Session
    {
        [JsonProperty("id")]
        public Guid Id { get; set; }
    }
}
