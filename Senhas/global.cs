using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace Senhas
{
    class global
    {

         static private string servidor = "localhost";
         static private string bancoDados = "sistema";
         static private string usuario = "root";
         static private string senha = "root";

        //conexão com o banco
         static public string strConn = $"server={servidor};User Id={usuario};database={bancoDados};password={senha};Convert Zero Datetime=True ";


       //  public static MySqlConnection Conexao;
        // public static MySqlCommand Comando;
        // public static MySqlDataAdapter Adaptador;
        // public static DataTable datTabela;

       // public static void conectar()
     //   {
        //    Conexao = new MySqlConnection("server=localhost;uid=root;pwd=root");

        //    Conexao.Open();

       //     Comando = new MySqlCommand("use sistema",Conexao);

     //       Comando.ExecuteNonQuery();

            

    //    }
    }



}
