using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace lib_entidades.Modelos
{
    public class ModuloRol
    {
        [Key] public int ID_Auditoria { get; set; }
        public int? ID_ModuloRol { get; set; }
        public int? ID_Rol { get; set; }
        public string? Permiso { get; set; }

        [NotMapped] public virtual ICollection<Mascotas>? Mascotas { get; set; }

        public bool Validar()
        {
            if (string.IsNullOrEmpty(Permiso))

                return false;
            return true;
        }




    }

}
