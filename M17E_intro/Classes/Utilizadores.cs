using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace M17E_intro.Classes
{
    public class Utilizadores
    {
        public int id;
        public string nome;
        public string email;
        public string password;
        public int sal;
        public int perfil;
        BaseDados bd;

        public Utilizadores()
        {
            bd = new BaseDados();
        }

        public bool VerificaLogin()
        {
            DataTable dados;
            string sql = @"select * from utilizadores where email = @email AND palavra_passe = HASHBYTES('SHA2_512',concat(@palavra_passe,sal))";

            List<SqlParameter> parametros = new List<SqlParameter>()
            {
                new SqlParameter()
                {
                    ParameterName = '@email',
                    SqlDbType = SqlDbType.NVarChar,
                    Value = email
                },
                new SqlParameter()
                {
                    ParameterName='@palavra_passe',
                    SqlDbType=SqlDbType.NVarChar,
                    Value= password
                }
            };
            dados = bd.devolveSQL(sql, parametros);
            if (dados == null || dados.Rows.Count == 0)
                return false;
            id = int.Parse(dados.Rows[0]["id"].ToString());
            nome = dados.Rows[0]["nome"].ToString();
            email = dados.Rows[0]["email"].ToString();
            perfil = int.Parse(dados.Rows[0]["perfil"].ToString());
            return true;
        }
    }
}