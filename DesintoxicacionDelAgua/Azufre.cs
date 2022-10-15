using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesintoxicacionDelAgua
{
    public class Azufre
    {
        private double tempAzufre = 444.6;
        private double masaAzufre = 32.07;
        private double tempEbullicion;
        private double porcentajeAzufre;
        private double tiempoImplementacion;

        public double TempAzufre { get => tempAzufre; set => tempAzufre = value; }
        public double MasaAzufre { get => masaAzufre; set => masaAzufre = value; }
        public double TempEbullicion { get => tempEbullicion; set => tempEbullicion = value; }
        public double PorcentajeAzufre { get => porcentajeAzufre; set => porcentajeAzufre = value; }
        public double TiempoImplementacion { get => tiempoImplementacion; set => tiempoImplementacion = value; }
    }
}
