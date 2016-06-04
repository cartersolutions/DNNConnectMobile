﻿using System;

using Newtonsoft.Json;

namespace DNNConnect.Models
{
    public class LoginModel
    {
        public LoginModel()
        {
        }

        [JsonProperty("u")]
        public string Username { get; set; }

        [JsonProperty("p")]
        public string Password { get; set; }
    }
}

