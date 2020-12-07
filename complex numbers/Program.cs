using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace complex_numbers
{


    class Program
    {

        public struct Complex
        {
            public float real;
            public float imag;
        };

        static void Main(string[] args)
        {
            Complex z = new Complex();
            z.real = 3;
            z.imag = -5;
            Complex Z1 = new Complex();
            Z1.real = 2;
            Z1.imag = 5;
            Complex Z2 = new Complex();
            Z2.real = 2;
            Z2.imag = 5;
            DisplayComplex(z);
            Console.WriteLine("Z1 + Z2 = ");
            DisplayComplex(Add(Z1, Z2));
            Console.WriteLine("Z1 - Z2 = ");
            DisplayComplex(Substract(Z1, Z2));
            Console.WriteLine("Z1 * Z2 = ");
            DisplayComplex(Product(Z1, Z2));
            Console.WriteLine("Z1 / Z2 = ");
            DisplayComplex(Division(Z1, Z2));
            Console.WriteLine("Conj(Z) = ");
            DisplayComplex(Conj(z));
            Console.WriteLine("ABS(Z)=|Z| :{0:F}", Abs(z));
            
        }
      

        public static void DisplayComplex(Complex z1)
        {
            float x = z1.real;
            float y = z1.imag;
            if (x == 0 && y == 0)
            {
                Console.WriteLine("0");
            }
            else if (x == 0)
            {
                Console.WriteLine("{0:F} i", y);
            }
            else if (y == 0)
            {
                Console.WriteLine("{0:F}", x);
            }
            else if (y < 0)
            {
                Console.WriteLine("{0:F} - {1:F} i", z1.real, -z1.imag);
            }
            else
                Console.WriteLine("{0:F} + {1:F} i", z1.real, z1.imag);
        }
        public static Complex Add(Complex Z1, Complex Z2)
        {
            Complex Z;
            Z.real = Z1.real + Z2.real;
            Z.imag = Z1.imag + Z2.imag;
            return Z;
        }

        public static Complex Substract(Complex Z1, Complex Z2)
        {
            Complex Z;
            Z.real = Z1.real - Z2.real;
            Z.imag = Z1.imag - Z2.imag;
            return Z;
        }
        public static Complex Product(Complex Z1, Complex Z2)
        {
            Complex Z;
            Z.real = Z1.real * Z2.real - Z1.imag * Z2.imag;
            Z.imag = Z1.real * Z2.imag + Z1.imag * Z2.real;
            return Z;
        }
        public static Complex Division(Complex Z1, Complex Z2)
        {
            Complex Z;
            float den = Z2.real * Z2.real + Z2.imag * Z2.imag;
            Z.real = (Z1.real * Z2.real + Z1.imag * Z2.imag) / den;
            Z.imag = (Z1.imag * Z2.real - Z1.real * Z2.imag) / den;
            return Z;
        }
        public static Complex Conj(Complex Z)
        {
            Complex Zc;
            Zc.real = Z.real;
            Zc.imag = -Z.imag;
            return Zc;
        }
        public static float Abs (Complex Z)
         {
          
            float result = (float)Math.Sqrt(Convert.ToDouble(Z.imag * Z.imag + Z.real * Z.real));
            return result;
        }


    }
}
