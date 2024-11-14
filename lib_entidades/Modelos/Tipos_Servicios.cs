using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lib_entidades.Modelos
{
    public class Tipos_servicios
    {
        [Key] public int ID_TipoServicio { get; set; }
        public string? Tipo_Servicio { get; set; }
        public int Servicio { get; set; }

        [NotMapped] public Servicios? _Servicio { get; set; }
    }
}
