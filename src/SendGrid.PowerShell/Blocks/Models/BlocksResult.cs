﻿using System;

using Newtonsoft.Json;

namespace SendGrid.PowerShell.Blocks.Models
{
    public class BlocksResult
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("created")]
        public DateTime Created { get; set; }

        [JsonProperty("reason")]
        public string Reason { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }
    }
}
