﻿using System;
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
        public int Eliminado = 0;

        public void Guardar()
        {
            string sql = $"INSERT INTO personas (nombre, apellido,eliminado) VALUES('{this.Nombre}','{this.Apellido}','{this.Eliminado}')";
            this.Comando.CommandText = sql;
            this.Comando.ExecuteNonQuery();

        }

        public void Borrar()
        {
            string sql = $"UPDATE personas SET eliminado = true WHERE id ='{this.Id}'";
            this.Comando.CommandText = sql;
            this.Comando.ExecuteNonQuery();
        }

        public void ModificarNombre()
        {
            string sql = $"UPDATE personas SET nombre = '{this.Nombre}' WHERE id ='{this.Id}'";
            this.Comando.CommandText = sql;
            this.Comando.ExecuteNonQuery();
        }
        public void ModificarApellido()
        {
            string sql = $"UPDATE personas SET apellido = '{this.Apellido}' WHERE id ='{this.Id}'";
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
                pm.Id = Int32.Parse(this.Lector["id"].ToString());
                pm.Nombre = this.Lector["nombre"].ToString();
                pm.Apellido = this.Lector["apellido"].ToString();
                bd.Add(pm);
            }
            return bd;

        }
        public List<PersonasModelos> ObtenerBloqueados()
        {
            List<PersonasModelos> bd = new List<PersonasModelos>();

            string sql = $"SELECT * FROM personas WHERE eliminado = true";
            this.Comando.CommandText = sql;
            this.Lector = this.Comando.ExecuteReader();

            while (this.Lector.Read())
            {
                PersonasModelos pm = new PersonasModelos();
                pm.Id = Int32.Parse(this.Lector["id"].ToString());
                pm.Nombre = this.Lector["nombre"].ToString();
                pm.Apellido = this.Lector["apellido"].ToString();
                bd.Add(pm);
            }
            return bd;

        }
        public List<PersonasModelos> ObtenerPorId()
        {
            List<PersonasModelos> bd = new List<PersonasModelos>();

            string sql = $"SELECT * FROM personas WHERE id = '{this.Id}'";
            this.Comando.CommandText = sql;
            this.Lector = this.Comando.ExecuteReader();

            while (this.Lector.Read())
            {
                PersonasModelos pm = new PersonasModelos();
                pm.Id = Int32.Parse(this.Lector["id"].ToString());
                pm.Nombre = this.Lector["nombre"].ToString();
                pm.Apellido = this.Lector["apellido"].ToString();
                bd.Add(pm);
            }
            return bd;

        }
        public List<PersonasModelos> ObtenerPorNombre()
        {
            List<PersonasModelos> bd = new List<PersonasModelos>();

            string sql = $"SELECT * FROM personas WHERE nombre = '{this.Nombre}'";
            this.Comando.CommandText = sql;
            this.Lector = this.Comando.ExecuteReader();

            while (this.Lector.Read())
            {
                PersonasModelos pm = new PersonasModelos();
                pm.Id = Int32.Parse(this.Lector["id"].ToString());
                pm.Nombre = this.Lector["nombre"].ToString();
                pm.Apellido = this.Lector["apellido"].ToString();
                bd.Add(pm);
            }
            return bd;

        }
        public List<PersonasModelos> ObtenerPorApellido()
        {
            List<PersonasModelos> bd = new List<PersonasModelos>();

            string sql = $"SELECT * FROM personas WHERE apellido = '{this.Apellido}'";
            this.Comando.CommandText = sql;
            this.Lector = this.Comando.ExecuteReader();

            while (this.Lector.Read())
            {
                PersonasModelos pm = new PersonasModelos();
                pm.Id = Int32.Parse(this.Lector["id"].ToString());
                pm.Nombre = this.Lector["nombre"].ToString();
                pm.Apellido = this.Lector["apellido"].ToString();
                bd.Add(pm);
            }
            return bd;

        }

    }
}
