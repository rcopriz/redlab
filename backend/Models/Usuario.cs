
/*namespace PruebaRedLab.Models
{
    public class Usuario
    {
    }
}
*/
using System;
using System.Collections.Generic;

namespace PruebaRedLab.Models
{
    public class Usuario
    {
        public int Id { get; set; }

        public string? Nombre { get; set; }

        public string? Correo { get; set; }

        public string? Clave { get; set; }
    }
}