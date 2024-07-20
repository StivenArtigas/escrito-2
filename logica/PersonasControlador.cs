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
        public static void Alta(string nombre, string apellido)
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
        public static void ModificarNombre(string id, string nombre)
        {
            PersonasModelos persona = new PersonasModelos();
            persona.Id = Int32.Parse(id);
            persona.Nombre = nombre;
            persona.ModificarNombre();
        }
        public static void ModificarApellido(string id, string apellido)
        {
            PersonasModelos persona = new PersonasModelos();
            persona.Id = Int32.Parse(id);
            persona.Apellido = apellido;
            persona.ModificarApellido();
        }
        public static DataTable Listar()
        {
            DataTable tabla = new DataTable();
           tabla.Columns.Add("id", typeof(int));
           tabla.Columns.Add("nombre", typeof(string));
           tabla.Columns.Add("apellido", typeof(string));


            PersonasModelos ListarPersonas = new PersonasModelos();
            foreach (PersonasModelos p in ListarPersonas.ObtenerTodos())
            {
                DataRow fila = tabla.NewRow();
                fila["id"] = p.Id;
                fila["Nombre"] = p.Nombre;
                fila["Apellido"] = p.Apellido;
                tabla.Rows.Add(fila);
            }

            return tabla;
        }
        public static DataTable ListarBloqueados()
        {
            DataTable tabla = new DataTable();
            tabla.Columns.Add("id", typeof(int));
            tabla.Columns.Add("nombre", typeof(string));
            tabla.Columns.Add("apellido", typeof(string));


            PersonasModelos ListarPersonas = new PersonasModelos();
            foreach (PersonasModelos p in ListarPersonas.ObtenerBloqueados())
            {
                DataRow fila = tabla.NewRow();
                fila["id"] = p.Id;
                fila["Nombre"] = p.Nombre;
                fila["Apellido"] = p.Apellido;
                tabla.Rows.Add(fila);
            }

            return tabla;
        }
        
        
        
        public static DataTable BuscarID(String id)
        {
            PersonasModelos persona = new PersonasModelos();
            persona.Id = Int32.Parse(id);
            DataTable tabla = new DataTable();
            tabla.Columns.Add("id", typeof(int));
            tabla.Columns.Add("nombre", typeof(string));
            tabla.Columns.Add("apellido", typeof(string));


            PersonasModelos ListarPersonas = new PersonasModelos();
            foreach (PersonasModelos p in ListarPersonas.ObtenerPorId())
            {
                DataRow fila = tabla.NewRow();
                fila["id"] = p.Id;
                fila["Nombre"] = p.Nombre;
                fila["Apellido"] = p.Apellido;
                tabla.Rows.Add(fila);
            }

            return tabla;
        }
        public static DataTable BuscarNombre(string nombre)
        {
            DataTable tabla = new DataTable();
            PersonasModelos persona = new PersonasModelos();
            persona.Nombre = nombre;
            tabla.Columns.Add("id", typeof(int));
            tabla.Columns.Add("nombre", typeof(string));
            tabla.Columns.Add("apellido", typeof(string));


            PersonasModelos ListarPersonas = new PersonasModelos();
            foreach (PersonasModelos p in ListarPersonas.ObtenerPorNombre())
            {
                DataRow fila = tabla.NewRow();
                fila["id"] = p.Id;
                fila["Nombre"] = p.Nombre;
                fila["Apellido"] = p.Apellido;
                tabla.Rows.Add(fila);
            }

            return tabla;
        }
        public static DataTable BuscarApellido(string apellido)
        {
            DataTable tabla = new DataTable();
            PersonasModelos persona = new PersonasModelos();
            persona.Apellido = apellido;
            tabla.Columns.Add("id", typeof(int));
            tabla.Columns.Add("nombre", typeof(string));
            tabla.Columns.Add("apellido", typeof(string));


            PersonasModelos ListarPersonas = new PersonasModelos();
            foreach (PersonasModelos p in ListarPersonas.ObtenerPorApellido())
            {
                DataRow fila = tabla.NewRow();
                fila["id"] = p.Id;
                fila["Nombre"] = p.Nombre;
                fila["Apellido"] = p.Apellido;
                tabla.Rows.Add(fila);
            }

            return tabla;
        }
    }
}