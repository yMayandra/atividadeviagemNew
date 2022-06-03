using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividadeviagem.Model
{
    class Pacote
    {
        private static int codPac;
        private static double valorPac ;
        private static string origemPac;
        private static string destinoPac;
        private static string dataPacIda;
        private static string dataPacVlt;
        private static string descricaoPac;
        private static Array imagePac;
        private static string retorno;

        public static int CodPac { get => codPac; set => codPac = value; }
        public static double ValorPac { get => valorPac; set => valorPac = value; }
        public static string OrigemPac { get => origemPac; set => origemPac = value; }
        public static string DestinoPac { get => destinoPac; set => destinoPac = value; }
        public static string DataPacIda { get => dataPacIda; set => dataPacIda = value; }
        public static string DataPacVlt { get => dataPacVlt; set => dataPacVlt = value; }
        public static string DescricaoPac { get => descricaoPac; set => descricaoPac = value; }
        public static Array ImagePac { get => imagePac; set => imagePac = value; }
        public static string Retorno { get => retorno; set => retorno = value; }
    }
}
