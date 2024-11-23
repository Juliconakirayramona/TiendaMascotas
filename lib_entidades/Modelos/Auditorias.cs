﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lib_entidades.Modelos
{
    public class Auditorias
    {
        [Key] public int ID_Auditoria { get; set; }
        public string? Tabla { get; set; }
        public int? Referencia { get; set; }
        public string? Accion { get; set; }

        [NotMapped] public virtual ICollection<Mascotas>? Mascotas { get; set; }


       

    }
    
}
