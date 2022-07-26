using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturas
{
    public class Factura_C : Factura
    {
        public Factura_C(Cliente Cliente, List<DetalleFactura> DetalleDeFactura) : base(Cliente, DetalleDeFactura)
        {
        }
    }
}
