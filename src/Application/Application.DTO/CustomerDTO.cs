using System;

namespace SeidorArchitecture.DigitalB89.Application.DTO
{
    public class CustomerDTO
    {
        public string DNI { get; set; }

        public string Cliente { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public double Saldo { get; set; }

        public int Puntos { get; set; }
    }
}
