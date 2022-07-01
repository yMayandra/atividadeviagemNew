using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividadeviagem.Model
{
    class Venda
    {
        private static int codVen;
        private static int codCli;
        private static int codFun;
        private static int codPac;
        private static string pagoVen;
        private static string retorno;

        public static int CodVen { get => codVen; set => codVen = value; }
        public static int CodCli { get => codCli; set => codCli = value; }
        public static int CodFun { get => codFun; set => codFun = value; }
        public static int CodPac { get => codPac; set => codPac = value; }
        public static string PagoVen { get => pagoVen; set => pagoVen = value; }
        public static string Retorno { get => retorno; set => retorno = value; }
    }
}
