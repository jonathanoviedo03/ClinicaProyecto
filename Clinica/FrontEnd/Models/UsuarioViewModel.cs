﻿using System;
namespace FrontEnd.Models
{
	public class UsuarioViewModel
	{
        public int IdUsuario { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? Correo { get; set; }
        public int? Edad { get; set; }
        public string? Direccion { get; set; }
        public string? Clave { get; set; }
        public bool? StatusUsuario { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public int? IdRol { get; set; }
	}
}

