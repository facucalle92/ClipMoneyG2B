using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationClip.Models
{
    public class Cuenta
    {
        #region Atributos
        private int id;
        private string nombre;
        private string apellido;
        private int dni;
        private string email;
        private int cuil;
        private int telefono;
        private string nacionalidad;
        private string usuario;
        private string clave;
        private string situacion_crediticia;
        private int saldo;
        #endregion

        #region Constructor
        public Cuenta(int id, string nombre, string apellido, int dni, string email, int cuil, int telefono, string nacionalidad, string usuario, string clave, string situacion_crediticia, int saldo)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.email = email;
            this.cuil = cuil;
            this.telefono = telefono;
            this.nacionalidad = nacionalidad;
            this.usuario = usuario;
            this.clave = clave;
            this.situacion_crediticia = situacion_crediticia;
            this.saldo = saldo;
        }
        #endregion

        #region Métodos
        public string Nombre
        {
            get
            {
                { return nombre; }
            }
            set
            {
                { nombre = value; }
            }
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
        public string Apellido
        {
            get
            {
                { return apellido; }
            }
            set
            {
                { apellido = value; }
            }
        }
        public int Dni
        {
            get
            {
                { return dni; }
            }
            set
            {
                { dni = value; }
            }
        }
        public string Email
        {
            get
            {
                { return email; }
            }
            set
            {
                { email = value; }
            }
        }
        public int Cuil
        {
            get
            {
                { return cuil; }
            }
            set
            {
                { cuil = value; }
            }
        }
        public int Telefono
        {
            get
            {
                { return telefono; }
            }
            set
            {
                { telefono = value; }
            }
        }
        public string Nacionalidad
        {
            get
            {
                { return nacionalidad; }
            }
            set
            {
                { nacionalidad = value; }
            }
        }
        public string Usuario
        {
            get
            {
                { return usuario; }
            }
            set
            {
                { usuario = value; }
            }
        }
        public string Clave
        {
            get
            {
                { return clave; }
            }
            set
            {
                { clave = value; }
            }
        }
        public string Situacion_Crediticia
        {
            get
            {
                { return situacion_crediticia; }
            }
            set
            {
                { situacion_crediticia = value; }
            }
        }
        public int Saldo
        {
            get
            {
                { return saldo; }
            }
            set
            {
                { saldo = value; }
            }
        }
        #endregion
    }
}