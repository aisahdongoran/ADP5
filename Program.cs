using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Example
{
    class Computer
    {
        private double hardisk;
        private int baterai;
        private int lcd;
        
        public double Hardisk { get => hardisk; set => hardisk = value; }
        public int Baterai { get => baterai; set => baterai = value; }
        public int Lcd { get => lcd; set => lcd = value; }
        
        public Computer()
        {
            hardisk = 1000.0;
            baterai = 500;
            lcd = 150;
        }

        public Computer(double hardisk, int baterai, int lcd)
        {
            this.hardisk = hardisk;
            this.baterai = baterai;
            this.lcd = lcd;
        }

        public int downBrightness()
        {
            lcd = lcd - 20;
            return lcd;
        }
        public int upBrightness()
        {
            lcd = lcd + 20;
            return lcd;
        }
        public double addData()
        {
            hardisk = hardisk - 50;
            return hardisk;
        }
        public double deleteData()
        {
            hardisk = hardisk + 50;
            return hardisk;
        }
               
        class Program
        {
            static void Main(string[] args)
            {
                Computer com = new Computer(200, 80, 400);
                Console.WriteLine("Hardisk: {0}, Baterai    :{1}, Lcd   :{2}", com.Hardisk, com.Baterai, com.Lcd);
                com.addData();
                Console.WriteLine("Hardisk: {0}, Baterai    :{1}, Lcd   :{2}", com.Hardisk, com.Baterai, com.Lcd);


            }
        }
    }
}
