using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul3_1302200052
{
    internal class DoorMachine
    {
        enum State { terbuka, terkunci, exit };
        public static void Mulai()
        {
            Console.WriteLine("Masukan State");
            State state = State.terkunci;
            while (state != State.exit)
            {
                string inputan = Console.ReadLine();
                switch (inputan)
                {
                    case "terbuka":
                        Console.WriteLine("Pintu tidak terkunci");
                        Console.WriteLine();
                        break;
                    case "terkunci":
                        Console.WriteLine("Pintu terkunci");
                        Console.WriteLine();
                        break;
                    case "exit":
                        state = State.exit;
                        break;
                    default:
                        Console.WriteLine("Masukan ulang State");
                        break;
                }
            }

        }
    }
}