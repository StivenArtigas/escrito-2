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
        public static void Borrar(string id)
        {
            PersonasModelos persona = new PersonasModelos();
            persona.Id = Int32.Parse(id);
            persona.Borrar();
        }

        public static DataTable Listar()
        {
            DataTable tabla = new DataTable();
            tabla.Columns.Add("Id", typeof(int));
            tabla.Columns.Add("Nombre", typeof(string));
            tabla.Columns.Add("Apellido", typeof(string));


            PersonasModelos ListarPersonas = new PersonasModelos();
            foreach (PersonasModelos p in ListarPersonas.ObtenerTodos())
            {
                DataRow fila = tabla.NewRow();
                fila["Id"] = p.Id;
                fila["Nombre"] = p.Nombre;
                fila["Apellido"] = p.Apellido;
                tabla.Rows.Add(fila);
            }

            return tabla;
        }
    }
}