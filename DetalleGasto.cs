using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kendy.Registros.EN
{
    public class DetalleGasto
    {
        public int Id { get; set; }
        public string Comentario { get; set; }
        public float Monto { get; set; }
        public int GastoId { get; set; }
        public DetalleGasto() { }

        public DetalleGasto(int pId, string pComentario, float pMonto, int pGastoId)
        {
            Id = pId;
            Comentario = pComentario;
            Monto = pMonto;
            GastoId = pGastoId;
        }
    }
}
