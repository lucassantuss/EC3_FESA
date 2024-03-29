﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadAlunoMVC.DAO
{
    internal static class HelperDAO
    {
        public static void ExecutaSQL(
                    string sql,
                    SqlParameter[] parametros)
        {
            using (var conexao = ConexaoBD.GetConexao())
            {
                using (var comando = new SqlCommand(sql, conexao))
                {
                    if (parametros != null)
                        comando.Parameters.AddRange(parametros);
                    comando.ExecuteNonQuery();
                }
            }
        }

        public static DataTable ExecutaSelect(string sql,
                                              SqlParameter[] parametros)
        {
            using (var cx = ConexaoBD.GetConexao())
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(sql, cx))
                {
                    DataTable tabela = new DataTable();
                    if (parametros != null)
                        adapter.SelectCommand.Parameters.AddRange(parametros);
                    adapter.Fill(tabela);
                    return tabela;
                }
            }
        }

        public static object NullAsDbNull(object valor)
        {
            if (valor == null)
                return DBNull.Value;
            else
                return valor;
        }


    }
}
