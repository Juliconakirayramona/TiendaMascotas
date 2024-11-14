using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace lib_entidades.Modelos
{
    public class Tipos_servicios
    {
        [Key] public int ID_TipoServicio { get; set; }
        public string? Tipo_Servicio { get; set; }
        public int Servicio { get; set; }
        [NotMapped] public Servicios? _Servicio { get; set; }
        public bool Validar()
        {
            if (string.IsNullOrEmpty(Tipo_Servicio))
                return false;
            return true;
        }
    }
}
