using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kendy.Registros.EN
{
    public class Existencias
    {
        public int Id { get; set; }
        public int ProductoId { get; set; }
        public string Tipo { get; set; }
        public DateTime Fecha { get; set; }
        public Existencias () { }
        public Existencias(int pId, int pProductorId, string pTipo, DateTime pFecha)
        {
            Id = pId;
            ProductoId = pProductorId;
            Tipo = pTipo;
            Fecha = pFecha;
        }
    }
}
