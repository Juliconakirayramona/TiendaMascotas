using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace lib_entidades.Modelos
{
    public class Tipo_Mascotas
    {
        [Key] public int ID_TipoMascota { get; set; }
        public string? TipoDeMascota { get; set; }
        public int Mascota { get; set; }
        [ForeignKey("Mascota")] public Mascotas? _Mascota { get; set; }
        public bool Validar()
        {
            if (string.IsNullOrEmpty(TipoDeMascota) ||
                    Mascota <= 0)
                return false;
            return true;
        }
    }
}
