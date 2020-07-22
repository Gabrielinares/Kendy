using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kendy.Registros.EN
{
    public class DetalleFactura
    {
        public int Id { get; set; }
        public float Monto { get; set; }
        public int Unidades { get; set; }
        public int FacturaId { get; set; }
        public string NombreMarca { get; set; }
        public string FormaDePago { get; set; }
        public DetalleFactura() { }

        public DetalleFactura (int pId, float pMonto, int pUnidades, int pFacturaId, string pNombreMarca, string pFormaDePago)
        {
            Id = pId;
            Monto = pMonto;
            Unidades = pUnidades;
            FacturaId = pFacturaId;
            NombreMarca = pNombreMarca;
            FormaDePago = pFormaDePago;
        }
    

    }
}
