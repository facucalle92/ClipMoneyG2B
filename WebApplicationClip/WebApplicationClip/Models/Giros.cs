using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationClip.Models
{
    public class Giros : Operaciones
    {
        private int cuentaDestino;

        public Giros()
        {

        }

        public Giros(int id, Cuenta cuentaPropia, int monto, DateTime fecha, int cuentaDestino) : base(id, cuentaPropia, monto, fecha)
        {
            this.cuentaDestino = cuentaDestino;
        }

        public int CuentaDestino
        {
            get
            {
                { return cuentaDestino; }
            }
            set
            {
                { cuentaDestino = value; }
            }
        }
    }
}