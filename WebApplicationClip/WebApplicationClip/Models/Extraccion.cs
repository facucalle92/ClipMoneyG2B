using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationClip.Models
{
    public class Extraccion : Operaciones
    {

        public Extraccion()
        {

        }
        public Extraccion(int id, Cuenta cuentaPropia, int monto, DateTime fecha): base(id,cuentaPropia,monto,fecha)
        {

        }
    }
}