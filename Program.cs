using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace madlib
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string femaleName, femaleAdj01, femaleAdj02, pluralNoun, famousPerson, gerund;

            Console.WriteLine(".........................................................................");
            Console.WriteLine("........ ....... ....................................... ....... ........");
            Console.WriteLine(".....      ...      .................................      ...      .....");
            Console.WriteLine("....        .        ...............................        .        ....");
            Console.WriteLine("....                 ...............................                 ....");
            Console.WriteLine(".....               .................................               .....");
            Console.WriteLine("......             ...................................             ......");
            Console.WriteLine("........         .......................................         ........");
            Console.WriteLine("..........     ...........................................     ..........");
            Console.WriteLine("............ ............................................... ............");
            Console.WriteLine(".........................................................................");

            Console.WriteLine(".");
            Console.WriteLine(".");
            Console.WriteLine(".");
            Console.WriteLine(".");
            Console.WriteLine(".");
            Console.WriteLine(".");
            Console.WriteLine(".");

            Console.WriteLine("Bienvenida a esta novedosa, intrigante y, tal vez, perturbadora experiencia. Esperemos sea de tu agrado.");
            Console.WriteLine("No seas tan severa, esta es la primera aplicación creada por Jalilcito Inc.");

            Console.WriteLine(".");
            Console.WriteLine(".");
            Console.WriteLine(".");
            Console.WriteLine(".");
            Console.WriteLine(".");
            Console.WriteLine(".");
            Console.WriteLine(".");
            Console.WriteLine(".");

            Console.Write("- A continuación, te voy a pedir que escribas un ADEJETIVO FEMENINO o NEUTRO. Luego presioná la tecla ENTER: ");
            femaleAdj01 = Console.ReadLine();
            Console.WriteLine("|");
            Console.WriteLine("|");
            Console.Write("- ¡Bien! lo siguiente va a ser un gerundio ...ya sabés, esas acciones que temrinan en -ando/-iendo: ");
            gerund = Console.ReadLine();
            Console.WriteLine("|");
            Console.WriteLine("|");
            Console.Write("- Ahora un sustantivo masculino plural, el que sea, concreto o abstracto: ");
            pluralNoun = Console.ReadLine();
            Console.WriteLine("|");
            Console.WriteLine("|");
            Console.Write("- Un famoso o celebridad o cualquier persona, la primera que se te venga a la cabeza... ");
            famousPerson = Console.ReadLine();
            Console.WriteLine("|");
            Console.WriteLine("|");
            Console.Write("- Ya casi terminamos. Dame un adjetivo femenino, pero distinto del que usaste al principio: ");
            femaleAdj02 = Console.ReadLine();
            Console.WriteLine("|");
            Console.WriteLine("|");
            Console.Write("- y por último, tu nombre... ");
            femaleName = Console.ReadLine();

            Console.WriteLine(".");
            Console.WriteLine(".");
            Console.WriteLine(".");
            Console.WriteLine(".");
            Console.WriteLine(".");
            Console.WriteLine(".");
            Console.WriteLine(".");
            Console.WriteLine(".");

            Console.WriteLine("          Querida " + femaleName + ", te recuerdo y extraño");
            Console.WriteLine("|");
            Console.WriteLine("          Siempre tan " + femaleAdj02 + " y confundida");
            Console.WriteLine("|");
            Console.WriteLine("          " +femaleAdj01 + "mente me mirás a los ojos y recuerdo...");
            Console.WriteLine("|");
            Console.WriteLine("          Recuerdo tu obsesión con los " + pluralNoun +" y " + famousPerson);
            Console.WriteLine("|");
            Console.WriteLine("          Espero estas palabras te enuentren " + gerund + "... " + gerund + " muy lejos de mi");


            Console.ReadLine();
        }
    }
}
