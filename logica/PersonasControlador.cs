using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using persistencia;

namespace logica
{
    public class PersonaControladores
    {
        public static void alta(string nombre, string apellido)
        {
            PersonasModelos persona = new PersonasModelos();
            persona.Nombre = nombre;
            persona.Apellido = apellido;

            persona.Guardar();
        }

    }
}
