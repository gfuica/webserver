using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2
{
    public class Class1
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }

        public Class1()
        {
            this.Id = 0;
            this.Nombre = "";
            this.Telefono = "";
        }

        public Class1(int id, string nombre, string telefono)
        {
            this.Id = 0;
            this.Nombre = nombre;
            this.Telefono = telefono;
        }
    }
}