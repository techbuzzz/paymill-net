﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymillWrapper.Net
{
     [System.AttributeUsage(System.AttributeTargets.Property)]
    public class Updateable : System.Attribute
    {
        public String Name { get; set; }
    }
}
