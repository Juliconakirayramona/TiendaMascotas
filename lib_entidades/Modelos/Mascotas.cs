using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace lib_entidades.Modelos
{
    public class Mascotas
    {
        [Key] public int ID_Mascota { get; set; }
        public string? Cod_Mascota { get; set; }
        public string? Nombre { get; set; }
        public string? Genero { get; set; }
        public string? Edad { get; set; }
        public int Dueño { get; set; }
        //[NotMapped] public virtual ICollection<Tipos_Mascotas>? Tipos_Mascotas { get; set; }
        [ForeignKey("Dueño")] public Clientes? _Dueño { get; set; }

        public bool Validar()
        {
            if (string.IsNullOrEmpty(Cod_Mascota) ||
                string.IsNullOrEmpty(Nombre) ||
                    Dueño <= 0)

                return false;
            return true;
        }
    }
}
