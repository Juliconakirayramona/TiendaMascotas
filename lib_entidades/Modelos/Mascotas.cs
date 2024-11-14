using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using lib_entidades.Modelos;

namespace lib_entidades
{
    public class Mascotas
    {
        [Key] public int ID_Mascota { get; set; }
        public string? Cod_Mascota { get; set; }
        public string? Nombre { get; set; }
        public string? Genero { get; set; }
        public string? Edad { get; set; }
        public int Dueño { get; set; }
        [NotMapped] public Clientes? _Dueño { get; set; }
    }
}
