using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaWIZELL.Model
{
    public partial class ListaAlquiler
    {
        public int IdJuego { get; set; }
        public string Titulo { get; set; }
        public string Genero { get; set; }
        public System.DateTime FechaSalida { get; set; }
        public System.DateTime FechaEntrega { get; set; }
    }
}
