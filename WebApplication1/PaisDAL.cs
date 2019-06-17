using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1
{
    // DAL Data Access Layer, DAO Data Access object
    // o REPO
    public class PaisDAL
    {
        // DAO->ADO->(.net)->ADO.NET-> LINQ2SQL (MUERTA) -> ENTITY FRAMEWORK

        public static List<Pais> ListarTodo()
        {
            List<Pais> listado=new List<Pais>();
            // usando ado.net
            // 1) Crear una conexion a la base 
            string cadena= "Data Source=192.168.0.130;Initial Catalog=junio17;Persist Security Info=True;User ID=sa;Password=abc.123";
            SqlConnection con=new SqlConnection(cadena);
            con.Open();

            // 2) Crear un comando. select * from paises
            string sql= "select * from paises";
            SqlCommand comando=new SqlCommand(sql,con);


            // 3) Ejecutarlo
            SqlDataReader lector =comando.ExecuteReader();
            // 4) leer linea a linea
            while(lector.Read())
            {
                Pais tmp=new Pais();
                tmp.PaisId=lector.GetInt32(0);
                tmp.Nombre=lector.GetString(1);
                listado.Add(tmp);
            }
            // 5) regreso la informacion
            con.Dispose();


            return listado;
        }

    }
}