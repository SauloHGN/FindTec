using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindTec
{
    public class DadosUsuario
    {
        // ListaCoordenador: (ID, NOME, EMAIL, TELEFONE, SENHA, codigo)
        public static List<(int, string, string, string, string, string)> listaCoordenador = new List<(int, string, string, string, string, string)>();

        // ListaAlunos: (ID, NOME, EMAIL, TELEFONE, CURSO, SENHA, STATUS, codigo, aprovação)
        public static List<(int, string, string, string, string, string, bool, string, bool)> listaAlunos = new List<(int, string, string, string, string, string, bool, string, bool)>();

        // ListaEmpresa: (ID, NOME, EMAIL, TELEFONE, SENHA, STATUS, codigo, aprovação)
        public static List<(int, string, string, string, string, bool, string, bool)> listaEmpresas = new List<(int, string, string, string, string, bool, string, bool)>();

        //ListaAdmin: (ID, EMAIL, SENHA)
        public static List<(int, string, string)> listaAdmin = new List<(int, string, string)>();      
    }
}
