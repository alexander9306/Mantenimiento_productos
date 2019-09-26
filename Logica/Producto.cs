using System;

namespace Logica
{
    public class Producto
    {
        public string codigo { get; set; }
        public string nombre { get; set; }
        public string detalle { get; set; }
        public string costo { get; set; }
        public string precio { get; set; }
        public DateTime fechaCrea { get; set; }
        public DateTime fechaVec { get; set; }
        public string categoria { get; set; }
        public bool estado { get; set; }
    }
}
