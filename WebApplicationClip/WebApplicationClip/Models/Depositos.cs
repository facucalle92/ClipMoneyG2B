using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationClip.Models
{
    public class Depositos : Operaciones
    {
        private int cuentaDestino;

        public Depositos()
        {

        }

        public Depositos(int id, Cuenta cuentaPropia, int monto, DateTime fecha, int cuentaDestino) : base(id, cuentaPropia, monto, fecha)
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