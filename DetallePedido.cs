using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kendy.Registros.EN
{
    public class DetallePedido
    {
        public int Id { get; set; }
        public int PeriodoId { get; set; }
        public float Monto { get; set; }
        public int Unidades { get; set; }
        public string NombreProducto { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime FechaPrevistaLlegada { get; set; }
        public DetallePedido() { }

        public DetallePedido(int pId, int pPeriodoId, float pMonto, int pUnidades, string pNombreProducto, DateTime pFecha, DateTime pFechaPrevistaLlegada)
        {
            Id = pId;
            PeriodoId = pPeriodoId;
            Monto = pMonto;
            Unidades = pUnidades;
            NombreProducto = pNombreProducto;
            Fecha = pFecha;
            FechaPrevistaLlegada = pFechaPrevistaLlegada;
        }
    }
}