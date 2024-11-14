using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lib_entidades.Modelos
{
    public class Tipos_mascotas
    {
        [Key] public int ID_TipoMascota { get; set; }
        public string? TipoDeMascota { get; set; }
        public int Mascota { get; set; }
        [NotMapped] public Mascotas? _Especie { get; set; }
    }
}
