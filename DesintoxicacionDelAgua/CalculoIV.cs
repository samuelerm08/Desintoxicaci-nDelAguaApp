using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesintoxicacionDelAgua
{
    public class CalculoIV
    {
        private double IV;
        private Azufre azufre = new Azufre();
        private Costo costo = new Costo();

        public void GetIV()
        {
            Console.WriteLine("Ingrese el costo inicial");
            costo.CostoInicial = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el costo final");
            costo.CostoFinal = Convert.ToDouble(Console.ReadLine());

            IV = (costo.CostoInicial / costo.CostoFinal);
        }

        public void GetTemp()
        {
            Console.WriteLine("Ingrese temperatura de ebullicion");
            azufre.TempEbullicion = Convert.ToDouble(Console.ReadLine());

            if (azufre.TempEbullicion > azufre.TempAzufre)
            {
                IV = Math.Sign(-IV) * IV;
            }
        }

        public void GetPercent()
        {
            Console.WriteLine("Ingrese el porcentaje de azufre para la solución");
            azufre.PorcentajeAzufre = Convert.ToDouble(Console.ReadLine());

            IV += (azufre.MasaAzufre * (azufre.PorcentajeAzufre / 100));
        }

        public void Time()
        {
            Console.WriteLine("Ingrese el tiempo de implementación");
            azufre.TiempoImplementacion = Convert.ToDouble(Console.ReadLine());

            IV *= azufre.TiempoImplementacion;

            IV /= azufre.TiempoImplementacion;
        }

        public void Alternativa()
        {
            if (IV > 1.54)
            {
                Console.WriteLine($"IV = {IV}\nLa alternativa es la recomendada");
            }

            else
            {
                Console.WriteLine($"IV = {IV}\nLa alternativa no es recomendada");
            }
        }
    }
}
