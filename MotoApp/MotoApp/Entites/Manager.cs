﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoApp.Entites
{
    public class Manager : Employee
    {
        public override string ToString() => base.ToString()+ " (Manager)";
    }
}
