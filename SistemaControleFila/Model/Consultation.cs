using Microsoft.Data.SqlClient;
using SistemaControleFila.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaControleFila.Model
{
    internal class Consultation
    {

       
        public string Medico { get; set; }
        public int Paciente { get; set; }
        public int Exame { get; set; }


        //public bool gravarConsulta()
        //{
        //    Banco bd = new Banco();
        //    SqlConnection cn = bd.abrirConexao();
        //    SqlTransaction tran = cn.BeginTransaction();
        //    SqlCommand command = new SqlCommand();

        //    command.Connection = cn;
        //    command.Transaction = tran;
        //    command.CommandType = CommandType.Text;

        //    //command.CommandText = " insert into programadores values ('" + nome + "','" + linguagem + "','" + banco + "')";
        //    command.CommandText = " insert into programadores values (@nome, @linguagem, @banco)";
        //    command.Parameters.Add("@nome", SqlDbType.VarChar);
        //    command.Parameters.Add("@linguagem", SqlDbType.VarChar);
        //    command.Parameters.Add("@banco", SqlDbType.VarChar);
        //    command.Parameters[0].Value = Paciente;
        //    command.Parameters[1].Value = exames;
        //    command.Parameters[2].Value = Medico;

        //    try
        //    {
        //        command.ExecuteNonQuery();
        //        tran.Commit();

        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        tran.Rollback();

        //        return false;
        //    }

        //    finally
        //    {
        //        bd.fecharConexao();
        //    }

        //}

        //public bool excluirConsulta(int ID)
        //{
        //    Banco bd = new Banco();

        //    SqlConnection cn = bd.abrirConexao();
        //    SqlTransaction tran = cn.BeginTransaction();
        //    SqlCommand command = new SqlCommand();

        //    command.Connection = cn;
        //    command.Transaction = tran;
        //    command.CommandType = CommandType.Text;
        //    command.CommandText = "delete from programadores where id = @ID";
        //    command.Parameters.Add("@ID", SqlDbType.Int);
        //    command.Parameters[0].Value = ID;
        //    try
        //    {
        //        command.ExecuteNonQuery();
        //        tran.Commit();

        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        tran.Rollback();

        //        return false;
        //    }

        //    finally
        //    {
        //        bd.fecharConexao();
        //    }
        //}

        //public bool atualizarConsulta(int id, string nome, string linguagem, string banco)
        //{
        //    Banco bd = new Banco();

        //    SqlConnection cn = bd.abrirConexao();
        //    SqlTransaction tran = cn.BeginTransaction();

        //    SqlCommand command = new SqlCommand();
        //    command.Connection = cn;
        //    command.Transaction = tran;
        //    command.CommandType = CommandType.Text;
        //    command.CommandText = "update programadores set nome=@nome,linguagem= @linguagem,banco=@banco where id = @ID";
        //    command.Parameters.Add("@ID", SqlDbType.Int);
        //    command.Parameters.Add("@nome", SqlDbType.VarChar);
        //    command.Parameters.Add("@linguagem", SqlDbType.VarChar);
        //    command.Parameters.Add("@banco", SqlDbType.VarChar);
        //    command.Parameters[0].Value = id;
        //    command.Parameters[1].Value = nome;
        //    command.Parameters[2].Value = linguagem;
        //    command.Parameters[3].Value = banco;

        //    try
        //    {
        //        command.ExecuteNonQuery();
        //        tran.Commit();
        //        MessageBox.Show("Programador Atualizado com Sucesso!");
        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        tran.Rollback();

        //        return false;
        //    }

        //    finally
        //    {
        //        bd.fecharConexao();
        //    }

        //}


        public Consultation retornaConsultas(int id)
        {
            Banco bd = new Banco();
            try
            {
                SqlConnection cn = bd.abrirConexao();
                SqlCommand command = new SqlCommand("SELECT * from dbo.ListExams", cn);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if (reader.GetInt32(0) == id)
                    {
                        Paciente = reader.GetInt32(0);
                        Exame = reader.GetInt32(1);

                        return this;
                    }
                }
                return null;
            }
            catch (Exception ex)
            {

                return null;
            }
            finally
            {
                bd.fecharConexao();
            }
        }

        public Consultation retornaPatiente(string name)
        {
            //Banco bd = new Banco();
            //try
            //{
            //    SqlConnection cn = bd.abrirConexao();
            //    SqlCommand command = new SqlCommand("SELECT FistName,LastName from dbo.Patients where FistName like% ", cn);
            //    SqlDataReader reader = command.ExecuteReader();

            //    while (reader.Read())
            //    {
            //        if (reader.GetInt32(0) == id)
            //        {
            //            Paciente = reader.GetInt32(0);
            //            Exame = reader.GetInt32(1);

            //            return this;
            //        }
            //    }
            //    return null;
            //}
            //catch (Exception ex)
            //{
               return null;
            //}
            //finally
            //{
            //    bd.fecharConexao();
            //}
        }


    }
}
