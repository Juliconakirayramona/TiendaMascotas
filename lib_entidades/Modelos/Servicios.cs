using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lib_entidades.Modelos
{
    public class Servicios
    {
        [Key] public int ID_Servicio { get; set; }
        public decimal Precio { get; set; }
        public bool Estado { get; set; }
        public int Mascota { get; set; }

        [NotMapped] public Mascotas? _Especie { get; set; }
    }
}
