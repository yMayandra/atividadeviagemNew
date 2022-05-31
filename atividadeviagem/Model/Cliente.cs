using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividadeviagem.Model
{
    class Cliente
    {
        private static int codCli;
        private static string nomeCli;
        private static string emailCli;
        private static string senhaCli;
        private static Array imageCli;
        private static string retorno;

        public static int CodCli { get => codCli; set => codCli = value; }
        public static string NomeCli { get => nomeCli; set => nomeCli = value; }
        public static string EmailCli { get => emailCli; set => emailCli = value; }
        public static string SenhaCli { get => senhaCli; set => senhaCli = value; }
        public static Array ImageCli { get => imageCli; set => imageCli = value; }
        public static string Retorno { get => retorno; set => retorno = value; }
    }
}