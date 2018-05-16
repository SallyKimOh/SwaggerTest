﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SwaggerTest.Models.Common;

namespace SwaggerTest.Models.Account
{
    public class AccountInfo<T> : CommInfo<T>
    {
        public string Name { get; set; }
    }
}
