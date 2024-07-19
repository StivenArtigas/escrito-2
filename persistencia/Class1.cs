using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace persistencia
{
    public class base_de_datos
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

        public List<base_de_datos> ObtenerTodos()
        {
            List<base_de_datos> bd = new List<base_de_datos>();

            string sql = $"SELECT * FROM personas WHERE eliminado = false";
            this.Comando.CommandText = sql;
            this.Lector = this.Comando.ExecuteReader();

            while (this.Lector.Read())
            {
                base_de_datos bd = new base_de_datos();
                bd.Id = Int32.Parse(this.Lector["Id"].ToString());
                bd.Nombre = this.Lector["Nombre"].ToString();
                bd.Precio = this.Lector["Apellido"].ToString());
                bd.Add(pizza);
            }
            return bd;

        }
    }
}
