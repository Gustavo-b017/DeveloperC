using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Carro
    {

        private int chassis;
        private string licensePlate;
        private string color;
        private string motor;



        public Carro(int chassis, string licensePlate, string color, string mortor)
        {
            this.chassis = chassis;
            this.licensePlate = licensePlate;
            this.color = color;
            this.motor = mortor;

            Console.WriteLine("Chassis: " + chassis);
            Console.WriteLine("License Plate: " + licensePlate);
            Console.WriteLine("Color: " + color);
            Console.WriteLine("Motor: " + motor);
        }


    }
}
