﻿using System;

namespace SeidorArchitecture.DigitalB89.Domain.Entity
{
    public class Customer
    {
        public string DNI { get; set; }

        public string Cliente { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public double Saldo { get; set; }

        public int Puntos { get; set; }
    }
}
