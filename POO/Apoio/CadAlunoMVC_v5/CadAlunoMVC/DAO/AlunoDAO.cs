using CadAlunoMVC.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadAlunoMVC.DAO
{
    public class AlunoDAO
    {

        private SqlParameter[] CriaParametros(AlunoViewModel aluno)
        {
            SqlParameter[] p = new SqlParameter[5];
            p[0] = new SqlParameter("id", aluno.Id);
            p[1] = new SqlParameter("nome", aluno.Nome);
            p[2] = new SqlParameter("mensalidade", HelperDAO.NullAsDbNull(aluno.Mensalidade));
            p[3] = new SqlParameter(nameof(aluno.DataNascimento), aluno.DataNascimento);
            p[4] = new SqlParameter("cidadeId", aluno.CidadeId);
            return p;
        }



        /// <summary>
        /// Método para inserir um aluno no BD
        /// </summary>
        /// <param name="aluno">objeto aluno com todas os atributos preenchidos</param>
        public void Inserir(AlunoViewModel aluno)
        {
            string sql =
            "insert into alunos(id, nome, mensalidade, " +
            "cidadeId, dataNascimento)" +
            "values (@id , @nome, @mensalidade, " +
            "@cidadeId, @dataNascimento )";
            HelperDAO.ExecutaSQL(sql, CriaParametros(aluno));
        }


        public void Alterar(AlunoViewModel aluno)
        {
            string sql =
            "update alunos set nome=@nome, mensalidade=@mensalidade, " +
            "cidadeId=@cidadeId, dataNascimento = @dataNascimento " +
            "where id = @id";
            HelperDAO.ExecutaSQL(sql, CriaParametros(aluno));
        }

        public void Excluir(int id)
        {
            string sql = "delete alunos where id = " + id;
            HelperDAO.ExecutaSQL(sql, null);
        }


        public AlunoViewModel Consulta(int id)
        {
            string sql = "select * from alunos where id =" + id;
            DataTable tabela = HelperDAO.ExecutaSelect(sql, null);

            if (tabela.Rows.Count == 0)
                return null;
            else
                return MontaAluno(tabela.Rows[0]);
        }


        private AlunoViewModel MontaAluno(DataRow registro)
        {
            AlunoViewModel a = new AlunoViewModel();
            a.Id = Convert.ToInt32(registro["id"]);
            a.CidadeId = Convert.ToInt32(registro["cidadeid"]);
            if (registro["mensalidade"] != DBNull.Value)
                a.Mensalidade = Convert.ToDouble(registro["mensalidade"]);
            a.Nome = registro["nome"].ToString();
            a.DataNascimento = Convert.ToDateTime(registro["dataNascimento"]);
            return a;
        }

        public List<AlunoViewModel> Listagem()
        {
            List<AlunoViewModel> lista = new List<AlunoViewModel>();
            string sql = "select * from alunos order by nome";
            DataTable tabela = HelperDAO.ExecutaSelect(sql, null);
            foreach (DataRow registro in tabela.Rows)
                lista.Add(MontaAluno(registro));
            return lista;
        }

        public int ProximoId()
        {
            string sql = "select isnull(max(id) +1, 1) as 'MAIOR' from alunos";
            DataTable tabela = HelperDAO.ExecutaSelect(sql, null);
            return Convert.ToInt32(tabela.Rows[0]["MAIOR"]);
        }
    }
}

