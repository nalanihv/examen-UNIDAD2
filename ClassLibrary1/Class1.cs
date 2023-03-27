using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
       public string nombreVendedor;
       public int antiguedad;
       public int edad;
       public string horario;
      public  string[] productosDisponibles = { "guitarra1","guitarraElectica","acustica","guitarraPro"};
        double[] precioDeProductos = {4000,5390,4000,12000};
        static int noVentas;

        public Class1() {

            edad = 18;
            horario = "Matutino";

        }
        static Class1() {
          noVentas = 1000;
        }


       public bool CheckProducto( out double precioTotal, int cantidad=1,params string[] producto) {

            precioTotal = 0;
            foreach (string prod in producto) {

                for (int i=0; i<=productosDisponibles.Length;i++) {

                    if (prod == productosDisponibles[i])
                    {
                        precioTotal =cantidad*precioDeProductos[i];
                      //  Console.WriteLine("precio del producto: "+precioTotal);
                        return true;
                    }

                }
            }
            return false;
        }

        public void Comision(string nombreVendedor, double precioTotal,int antiguedad=0) {

            if (antiguedad == 0 && precioTotal > 0)
                noVentas++;
            else if (antiguedad >= 5 && antiguedad <= 30 && precioTotal > 3000)
                noVentas=noVentas+ 2;



            // noVentas=  noVentas- 1000 ;
            Console.WriteLine("nombre del vendedor: " + nombreVendedor);
            Console.WriteLine("su antiguedad "+antiguedad);
            Console.WriteLine("precio total "+precioTotal);
            Console.WriteLine("Numero de transacciones: "+(noVentas-1000));
        }



    }

}
