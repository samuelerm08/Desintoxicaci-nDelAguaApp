using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesintoxicacionDelAgua
{
    internal class App
    {
        private CalculoIV calculoIV = new CalculoIV();
                
        public void Start()
        {            
            //Calculo Indice Verificador
            calculoIV.GetIV();
            
            //Verificar si la temperatura de ebullición es superior a la del Azufre
            calculoIV.GetTemp();

            //Sumar por masa de Azufre multiplicado por su porcentaje
            calculoIV.GetPercent();
            
            //Implementación del tiempo
            calculoIV.Time();

            //Alternativa
            calculoIV.Alternativa();

            Console.ReadKey();
        }
    }
}
