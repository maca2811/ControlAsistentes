﻿using System;

namespace Entidades
{
    /// <summary>
    /// Mariela Calvo
    /// 20/noviembre/2019
    /// Clase para administrar la entidad Asistente
    /// </summary>
    public class Asistente
    {
        public int idAsistente { get; set; }
        public string nombreCompleto{get;set; }
        public string carnet { get; set; }
        public string telefono { get; set; }
        public string correo { get; set; }
        public bool nombrado { get; set; }
        public bool recibeInduccion { get; set; }
        public Archivo archivo { get; set; }
        public Periodo periodo { get; set; }
        public Encargado encargado { get; set; }
        public int cantidadHorasNombrado { get; set; }
        public int cantidadPeriodosNombrados { get; set; }






    }
}
