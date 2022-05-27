using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividadeviagem.Controller
{
    class Conexao
    {
       public static string conectar()
        {
            return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mayandra.vmota\Source\Repos\atividadeviagemNew\atividadeviagem\BancodeDados\bdAgenciaViajens.mdf;Integrated Security=True";
        }
    }
}
