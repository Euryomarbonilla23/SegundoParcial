using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SegundoParcial.Entidades
{
     public class Tipos
    {
        [Key]
        public int TipoId { get; set; }
        public string TipoTarea { get; set; }
    }
}