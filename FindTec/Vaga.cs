using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindTec
{
    public class Vaga
    {
        public string NomeVaga { get; set; }
        public string NomeEmpresa { get; set; }
        public string Cargo { get; set; }
        public int cargaHoraria { get; set; }
        public double remuneracao { get; set; }
        public string Curso { get; set; }
        public string Descricao { get; set; }
        public bool Disponivel { get; set; }
        public byte[] Foto { get; set; }
        public List<string> Candidatos { get; set; }
  

        public static List<Vaga> vagas = new List<Vaga>();

        public Vaga(string nomeV, string nomeE, string cargo, int cargaH, double salario, string curso, string descricao)
        {

            NomeVaga = nomeV;
            NomeEmpresa = nomeE;
            Cargo = cargo;
            cargaHoraria = cargaH;
            remuneracao = salario;
            Curso = curso;
            Descricao = descricao;
            Disponivel = true;
            Candidatos = new List<string>();
        }

        public static void addVaga(Vaga novaVaga)
        {
            // adiciona nova vaga
            vagas.Add(novaVaga);
        }

        public byte[] getFoto(string nomeEmpresa)
        {
            foreach (var empresa in DadosUsuario.listaEmpresas)
            {
                if (empresa.Item2 == nomeEmpresa)
                {                 
                    Foto = empresa.Item9;
                    return Foto;
                    
                }
            }

            return null;
        }

        public static List<Vaga> getVagasPorCurso(string curso)
        {
            // retorna vaga de acordo com o curso
            return vagas.Where(v => v.Curso == curso).ToList();
        }

        public static Vaga getVagasPorNomeEmpresa(string nomeEmpresa)
        {
            //return vagas.Where(v => v.nomeEmpresa == nomeEmpresa).ToList();
            foreach (var vaga in vagas)
            {
                if (vaga.NomeEmpresa == nomeEmpresa)
                {                   
                    return vaga;
                }
            }
            return null;
        }
        
        public static Vaga getVagaPorNome(string nomeVaga)
        {
            //return vagas.FirstOrDefault(v => v.nomeVaga == nomeVaga);
            foreach (var vaga in vagas)
            {
                if (vaga.NomeVaga == nomeVaga)
                {
                    return vaga;
                }
            }
            return null;
        }

    }
}
