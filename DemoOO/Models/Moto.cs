﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOO.Models
{
    internal class Moto : Vehicule
    {
        public override int NbRoue { get => base.NbRoue; set => base.NbRoue = value; }
    }
}
