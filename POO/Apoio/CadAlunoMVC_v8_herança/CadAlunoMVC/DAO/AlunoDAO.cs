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
    public class AlunoDAO : PadraoDAO<AlunoViewModel>
    {
        protected override SqlParameter[] CriaParametros(AlunoViewModel aluno)
        {
            SqlParameter[] p = new SqlParameter[5];
            p[0] = new SqlParameter("id", aluno.Id);
            p[1] = new SqlParameter("nome", aluno.Nome);
            p[2] = new SqlParameter("mensalidade", HelperDAO.NullAsDbNull(aluno.Mensalidade));
            p[3] = new SqlParameter(nameof(aluno.DataNascimento), aluno.DataNascimento);
            p[4] = new SqlParameter("cidadeId", aluno.CidadeId);
            return p;
        }

        protected override AlunoViewModel MontaModel(DataRow registro)
        {
            AlunoViewModel a = new AlunoViewModel();
            a.Id = Convert.ToInt32(registro["id"]);
            a.CidadeId = Convert.ToInt32(registro["cidadeid"]);
            if (registro["mensalidade"] != DBNull.Value)
                a.Mensalidade = Convert.ToDouble(registro["mensalidade"]);
            a.Nome = registro["nome"].ToString();
            a.DataNascimento = Convert.ToDateTime(registro["dataNascimento"]);

            if (registro.Table.Columns.Contains("NomeCidade"))
                a.NomeCidade = registro["NomeCidade"].ToString();

            return a;
        }

        protected override void SetTabela()
        {
            Tabela = "Alunos";
            NomeSpListagem = "spListagemAlunos";
        }
    }
}


/*
ALTER PROCEDURE [dbo].[spListagemAlunos](
  @tabela varchar(max),
  @ordem varchar(max))
AS
  BEGIN
    SELECT alunos.*, cidades.nome as 'NomeCidade'
    FROM   alunos
	left join cidades on cidades.id = alunos.cidadeId
  END

 
 * 
 * */