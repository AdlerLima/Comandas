﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace SistemDeCaixa
{
    class clnConexao
    {
        private NpgsqlConnection conn;
        private string sql;
        private DataTable dt;
        private NpgsqlCommand cmd;
        private string connstring = String.Format("username = postgres; password = postgres; host = localhost; Port = 5432; Database = comandas");
        public void connection()
        {
            
            conn = new NpgsqlConnection(connstring);
            conn.Open();
        }
        public void closeconnection()
        {
            conn.Close();
        }
        public int funcoes(string sql)
        {
            
            int result = 0;
            cmd = new NpgsqlCommand(sql, conn);
            result = (int)cmd.ExecuteScalar();
            conn.Close();
            return result;
        }
        public void SelectProd()
        {
            conn.Open();
            sql = @"SELECT * FROM PRODUTO";
            cmd = new NpgsqlCommand(sql, conn);
            dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            conn.Close();
        }
        public void selectCom(string sql)
        {
            conn.Open();
            cmd = new NpgsqlCommand(sql, conn);
            cmd.ExecuteScalar();

        }

        public decimal teste(string sql)
        {
            decimal result = 0;
            cmd = new NpgsqlCommand(sql, conn);
            try
            {
                result = (decimal)cmd.ExecuteScalar();
            }catch(Exception ex)
            {
                
            }
            conn.Close();
            return result;
        }
        public void selectfinalizar(int codCliente)
        {
            
            sql = @"SELECT CPF FROM CLIENTE";
            cmd = new NpgsqlCommand(sql, conn);
            dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            conn.Close();
        }

    }
    
}
