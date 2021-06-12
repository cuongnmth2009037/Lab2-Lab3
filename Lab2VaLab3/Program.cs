using System;
using System.Security.Cryptography.X509Certificates;
using Lab2VaLab3.lab3;
using Lab2VaLab3.lab3.Exercise1;

namespace Lab2VaLab3
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            // Lab2:
            var sin = "193456787";
            if (sin.Length != 9)
            {
                Console.WriteLine("sin phai la chuoi 9 chu so");
                return;
            }

            var splittedSin = sin.ToCharArray();
            var sinInNumber = new int[9];
            for (int i = 0; i < splittedSin.Length; i++)
            {
                sinInNumber[i] = int.Parse(splittedSin[i].ToString());
            }

            var tongSoHangChan = 0;
            var tongSoHangLe = 0;
            for (int i = 0; i < sinInNumber.Length - 1; i++)
            {
                if (i % 2 == 0)
                {
                    tongSoHangLe += sinInNumber[i];
                }
                else
                {
                    var temp = (sinInNumber[i] * 2).ToString().ToCharArray();
                    for (int j = 0; j < temp.Length; j++)
                    {
                        tongSoHangChan += Convert.ToInt32(temp[j].ToString());
                    }
                }
            }

            var sum = tongSoHangChan + tongSoHangLe;
            if ((sum + sinInNumber[sinInNumber.Length - 1]) % 10 == 0)
            {
                Console.WriteLine("This is a valid SIN.");
            }
            else
            {
                Console.WriteLine(" This is not a valid SIN.");
            }
            
            
            
            // Lab3-Exercise1:
            // var atoms = new Atom[10];
            //  Console.WriteLine("Atomic Information");
            //  Console.WriteLine("==================");
            //  var count = 0;
            //  for (int i = 0; i < 10; i++)
            //  {
            //      var atom = new Atom();
            //      var result = atom.Accept();
            //      if (!result || atom.Number == 0)
            //      {
            //          break;
            //      }
            //      atoms[i] = atom;
            //      count++;
            //  }
            //
            //  Console.WriteLine("No Sym Name Weight");
            //  Console.WriteLine("------------------------------------");
            //  for (int i = 0; i < count; i++)
            //  {
            //      atoms[i].Display();
            //  }


            
            // Lab3-Exercise2:
            // var employee = new Employee("Cuong", "Nguyen", "so 8,ton that thuyet", 3, 9000000);
            // Console.WriteLine(employee.ToString());
            // Console.WriteLine("Enter percentage:");
            // var percentage = int.Parse(Console.ReadLine());
            // Console.WriteLine(employee.CalculBonus(percentage));

        }
    }
}

