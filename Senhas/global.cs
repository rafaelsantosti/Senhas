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

        static private string servidor = Properties.Settings.Default.servidor;
         static private string bancoDados = Properties.Settings.Default.bancoDados;
        static private string usuario = Properties.Settings.Default.usuario;
        static private string senha = Properties.Settings.Default.senha;

        //string de conexao com o mysql
        static public string strConn = "server='" + servidor + "';User Id='" + usuario + "';database='" + bancoDados + "';password='" + senha+ "';Convert Zero Datetime=True ";
        static public string server = "server='" + servidor + "';User Id='" + usuario + "';password='" + senha + "';Convert Zero Datetime=True ";

    }

    

}
