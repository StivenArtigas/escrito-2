using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace persistencia
{
    public abstract class Modelo
    {
        public string IP;
        public string NombreBase;
        public string NombreDeUsuario;
        public string Password;

        public MySqlConnection Conexion;
        public MySqlCommand Comando;
        public MySqlDataReader Lector;

        public Modelo()
        {
            this.IP = "127.0.0.1";
            this.NombreBase = "escrito2";
            this.Password = "Ss11331313$";
            this.NombreDeUsuario = "root";

            this.Conexion = new MySqlConnection(
                $"server={this.IP};" +
                $"user={this.NombreDeUsuario};" +
                $"password={this.Password};" +
                $"database={this.NombreBase};"
            );

            this.Conexion.Open();

            this.Comando = new MySqlCommand();
            this.Comando.Connection = this.Conexion;

        }

    }
}
/*Sentencias base de datos
create database escrito2;
use escrito2;
CREATE TABLE `personas` (
   `id` int NOT NULL AUTO_INCREMENT,
   `nombre` varchar(20) NOT NULL,
   `apellido` varchar(20) NOT NULL,
   `eliminado` tinyint(1) NOT NULL DEFAULT '0',
   PRIMARY KEY (`id`)
 )*/
