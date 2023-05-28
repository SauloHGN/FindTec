using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindTec
{
    public class DadosUsuario
    {
        // ListaCoordenador: (ID, NOME, EMAIL, TELEFONE, SENHA, codigo, foto)
        public static List<(int, string, string, string, string, string, byte[])> listaCoordenador = new List<(int, string, string, string, string, string, byte[])>();

        // ListaAlunos: (ID, NOME, EMAIL, TELEFONE, CURSO, SENHA, STATUS, codigo, aprovação, foto)
        public static List<(int, string, string, string, string, string, bool, string, bool, byte[])> listaAlunos = new List<(int, string, string, string, string, string, bool, string, bool, byte[])>();

        // ListaEmpresa: (ID, NOME, EMAIL, TELEFONE, SENHA, STATUS, codigo, aprovação, foto)
        public static List<(int, string, string, string, string, bool, string, bool, byte[])> listaEmpresas = new List<(int, string, string, string, string, bool, string, bool, byte [])>();

        //ListaAdmin: (ID, EMAIL, SENHA)
        public static List<(int, string, string)> listaAdmin = new List<(int, string, string)>();

    }
}