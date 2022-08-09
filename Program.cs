using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaLINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Obrero obrero = new Obrero();
            obrero.usarPala();
            obrero.usarCasco();
            obrero.usarMartillo();
            Console.ReadKey();
        }
        class Obrero : Icasco,Imartillo
        {
            public void usarPala()
            {
                Console.WriteLine("El obrero usa la pala para hacer la mezcla");
            }
            public void usarCasco()
            {
                Console.WriteLine("El obrero usa el casco por seguridad");
            }
            public void usarMartillo()
            {
                Console.WriteLine("El obrero usa el martillo para poner un clavo");
            }
        }
        interface Icasco
        {
            void usarCasco();
        }
        interface Imartillo
        {
            void usarMartillo();
        }
    }
}