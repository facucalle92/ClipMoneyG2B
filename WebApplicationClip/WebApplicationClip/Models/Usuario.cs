using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationClip.Models
{
    public class Usuario
    {
        private int id;
        private string nombre;
        private string apellido;
        private string email;
        private string password;
        private string provincia;
        private string ciudad;
        private string pais;
        private DateTime fechaNacimiento;
        private Cuenta cuentaPropia;

        public Usuario(int id, string nombre, string apellido, string email, string password, string provincia, string ciudad, string pais, DateTime fechaNacimiento, Cuenta cuentaPropia)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.email = email;
            this.password = password;
            this.provincia = provincia;
            this.ciudad = ciudad;
            this.pais = pais;
            this.fechaNacimiento = fechaNacimiento;
            this.cuentaPropia = cuentaPropia;
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
        public string Password
        {
            get
            {
                { return password; }
            }
            set
            {
                { password = value; }
            }
        }
        public string Provincia
        {
            get
            {
                { return provincia; }
            }
            set
            {
                { provincia = value; }
            }
        }
        public string Ciudad
        {
            get
            {
                { return ciudad; }
            }
            set
            {
                { ciudad = value; }
            }
        }
        public string Pais
        {
            get
            {
                { return pais; }
            }
            set
            {
                { pais = value; }
            }
        }
        public DateTime FechaNacimiento
        {
            get
            {
                { return fechaNacimiento; }
            }
            set
            {
                { fechaNacimiento = value; }
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
    }
}