using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle_de_Comissões
{
    internal class ConString
    {
        public static string path = Path.GetFullPath(Environment.CurrentDirectory);
        public static string Connection = @"Data Source=(localdb)\MSSQLLocalDB;AttachDbFilename=" + path + "\\db_Comission_Control.mdf;Trusted_Connection = True; Integrated Security=True";
    }
}
