using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindTec
{
    public class DadosUsuario
    {
        // ListaAluno: (ID, NOME, EMAIL, TELEFONE, CURSO, SENHA, STATUS)
        public static List<Tuple<int, string, string, string, string, string, bool>> listaAlunos = new List<Tuple<int, string, string, string, string, string, bool>>();

        // ListaEmpresa: (ID, NOME, EMAIL, TELEFONE, SENHA, STATUS)
        public static List<Tuple<int, string, string, string, string, bool>> listaEmpresas = new List<Tuple<int, string, string, string, string, bool>>();

    }
}
