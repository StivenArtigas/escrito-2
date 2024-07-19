using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace persistencia
{
    public class PersonasModelos : Modelo
    {
        public int Id;
        public string Nombre;
        public string Apellido;

        public void Guardar()
        {
            string sql = $"INSERT INTO personas (nombre, apellido) VALUES('{this.Nombre}',{this.Apellido})";
            this.Comando.CommandText = sql;
            this.Comando.ExecuteNonQuery();

        }

        public void Borrar()
        {
            string sql = $"UPDATE personas SET eliminado = true WHERE id ='{this.Id}'";
            this.Comando.CommandText = sql;
            this.Comando.ExecuteNonQuery();
        }

        public List<PersonasModelos> ObtenerTodos()
        {
            List<PersonasModelos> bd = new List<PersonasModelos>();

            string sql = $"SELECT * FROM personas WHERE eliminado = false";
            this.Comando.CommandText = sql;
            this.Lector = this.Comando.ExecuteReader();

            while (this.Lector.Read())
            {
                PersonasModelos pm = new PersonasModelos();
                pm.Id = Int32.Parse(this.Lector["Id"].ToString());
                pm.Nombre = this.Lector["Nombre"].ToString();
                pm.Apellido = this.Lector["Apellido"].ToString();
                bd.Add(pm);
            }
            return bd;

        }
    }
}
