using System.ComponentModel.DataAnnotations;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace lib_entidades.Modelos
{
    public class Clientes
    {
        [Key] public int ID_Persona { get; set; }
        public string? Cedula { get; set; }
        public string? Nombre { get; set; }

    }
    public bool Validar()
    {
        if (string.IsNullOrEmpty(Cedula) ||
            string.IsNullOrEmpty(Nombre))
            return false;
        return true;
    }
}
