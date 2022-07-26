using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturas
{
    public class Factura : IFactura
    {
        public Cliente Cliente { get; set; }
        List<DetalleFactura> DetalleDeFactura = new List<DetalleFactura>{ };

        public Factura(Cliente Cliente, List<DetalleFactura> DetalleDeFactura)
        {
            this.Cliente = Cliente;
            this.DetalleDeFactura = DetalleDeFactura;
        }
        public int CantidadItems()
        {
            int TotalItem = 0;
            foreach (var item in DetalleDeFactura)
            { 
                TotalItem += item.Cantidad;
            }
            return TotalItem;
        }
        public double Total()
        {
            double CantidadTotal = 0;
            foreach (var item in DetalleDeFactura)
            {
                CantidadTotal += item.SubTotal();
            }
            return CantidadTotal;
        }

    }
}
