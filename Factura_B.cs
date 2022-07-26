using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturas
{
    public class Factura_B : Factura
    {
        public Factura_B(Cliente Cliente, List<DetalleFactura> DetalleDeFactura) : base(Cliente, DetalleDeFactura)
        {
        }
    }
}
