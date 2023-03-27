using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double precioTotal=0; 

           Class1 vendedor=new Class1();
            Class1 cliente=new Class1();


           

            cliente.CheckProducto(out precioTotal,1,"guitarra1", "acustica");
            vendedor.Comision("Juan", precioTotal, 8);





        }


    }
}
