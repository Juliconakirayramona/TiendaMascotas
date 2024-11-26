using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace lib_entidades.Modelos
{
    public class Usuarios
    {
        [Key] public int ID_Usuario { get; set; }
        public string? Nombre { get; set; }
        public string? Email { get; set; }
        public string? Contraseña { get; set; }

        [NotMapped] public virtual ICollection<Mascotas>? Mascotas { get; set; }

        public bool Validar()
        {
            if (string.IsNullOrEmpty(Nombre))

                return false;
            return true;
        }




    }

}
