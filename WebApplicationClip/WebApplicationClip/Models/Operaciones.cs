using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationClip.Models
{
    public class Operaciones
    {
        private int id;
        private Cuenta cuentaPropia;
        private int monto;
        private DateTime fecha;

        public Operaciones()
        {

        }
        
        public Operaciones(int id, Cuenta cuentaPropia, int monto, DateTime fecha)
        {
            this.id = id;
            this.cuentaPropia = cuentaPropia;
            this.monto = monto;
            this.fecha = fecha;
        }
        
        public int Id
        {
            get
            {
                { return id; }
            }
            set
            {
                { id = value; }
            }
        }
        public Cuenta CuentaPropia
        {
            get
            {
                { return cuentaPropia; }
            }
            set
            {
                { cuentaPropia = value; }
            }
        }
        public int Monto
        {
            get
            {
                { return monto; }
            }
            set
            {
                { monto = value; }
            }
        }
        public DateTime Fecha
        {
            get
            {
                { return fecha; }
            }
            set
            {
                { fecha = value; }
            }
        }
    }
}