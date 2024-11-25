using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lib_entidades.Modelos
{
    public class Clientes
    {
        [Key] public int ID_Persona { get; set; }
        public string? Cedula { get; set; }
        public string? Nombre { get; set; }

        [NotMapped] public virtual ICollection<Mascotas>? Mascotas { get; set; }
        [NotMapped] public virtual ICollection<Facturas>? Facturas { get; set; }

        public bool Validar()
        {
            if (string.IsNullOrEmpty(Cedula) ||
                string.IsNullOrEmpty(Nombre))

                return false;
            return true;
        }

    }

}
