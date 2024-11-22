using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace lib_entidades.Modelos
{
    public class Clientes_mascotas
    {
        [Key] public int ID_TipoMascota { get; set; }
        public string? TipoDeMascota { get; set; }
        public int Mascota { get; set; }
        [NotMapped] public Mascotas? _Especie { get; set; }
        public bool Validar()
        {
            if (string.IsNullOrEmpty(TipoDeMascota))
                return false;
            return true;
        }
    }
}
