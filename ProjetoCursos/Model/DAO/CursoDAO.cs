﻿using ProjetoCursos.Model.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace ProjetoCursos.Model.DAO
{
    internal class CursoDAO
    {
        private MySqlConnection con;
        private string comandoSql = "";
        private MySqlCommand envelope;
        private MySqlDataReader cursor;
        private List<CursoDTO> listadecursos;

        public CursoDAO()
        {
            string strconexao = "server=localhost;userid=professor;password=professor@;database=bdcursos";
            con = new MySqlConnection(strconexao);
        }
        public bool Salvar(CursoDTO cursodto)
        {
            //Abrir o canal de comunicação
            con.Open();
            //Montar o comando SQL
            comandoSql = "INSERT INTO CURSO (nomecurso,turma,tipo,status) values (@nomecurso,@turma,@tipo,@status)";
            //Criando um Envelope de Comando
            envelope = new MySqlCommand();
            //Colocando o comando SQL dentro do envelope
            envelope.CommandText = comandoSql;
            //Colocando o envelope no canal de conexão
            envelope.Connection = con;
            //Colocar os valores vindo da tela no INSERT
            envelope.Parameters.AddWithValue("@nomecurso", cursodto.Nomecurso);
            envelope.Parameters.AddWithValue("@turma", cursodto.Turma);
            envelope.Parameters.AddWithValue("@tipo", cursodto.Tipo);
            envelope.Parameters.AddWithValue("@status", cursodto.Status);
            envelope.Prepare();
            int resultado = envelope.ExecuteNonQuery();
            //Fechar o canal de comunicação
            con.Close();
            if (resultado > 0)
            {   
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<CursoDTO> Listar() 
        {
            //Criar a Lista de Objetos
            listadecursos = new List<CursoDTO>();
            //Abrir o canal de comunicação
            con.Open();
            //Montar o comando SQL
            comandoSql = "SELECT * FROM Curso";
            //Criando um Envelope de Comando
            envelope = new MySqlCommand(comandoSql, con);
            envelope.Prepare();
            cursor = envelope.ExecuteReader();
            while (cursor.Read()) 
            {
                //Criação do Objeto DTO
                CursoDTO cursodto = new CursoDTO();
                //Carga dos dados vindo da Tabela para o Objeto
                cursodto.IdCurso = cursor.GetInt32("idcurso");
                cursodto.Nomecurso = cursor.GetString("nomecurso");
                cursodto.Turma = cursor.GetString("turma");
                cursodto.Tipo = cursor.GetString("tipo");
                cursodto.Status = cursor.GetString("status");
                //Adicionando o objeto preenchido a lista de cursos
                listadecursos.Add(cursodto);
            }
            return listadecursos;


        }

        public bool Apagar(int idcurso)
        {
            //Abrir o canal de comunicação
            con.Open();
            //Montar o comando SQL
            comandoSql = "DELETE FROM curso WHERE idcurso = @idcurso";
            //Criando um Envelope de Comando
            envelope = new MySqlCommand();
            //Colocando o comando SQL dentro do envelope
            envelope.CommandText = comandoSql;
            //Colocando o envelope no canal de conexão
            envelope.Connection = con;
            //Colocar os valores vindo da tela no DELETE
            envelope.Parameters.AddWithValue("@idcurso", idcurso);
            envelope.Prepare();
            int resultado = envelope.ExecuteNonQuery();
            //Fechar o canal de comunicação
            con.Close();
            if (resultado > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Atualizar(CursoDTO cursodto)
        {
            //Abrir o canal de comunicação
            con.Open();
            //Montar o comando SQL
            comandoSql = "UPDATE curso SET nomecurso = @nomecurso,turma=@turma,tipo=@tipo,status=@status WHERE idcurso = @idcurso";
            //Criando um Envelope de Comando
            envelope = new MySqlCommand();
            //Colocando o comando SQL dentro do envelope
            envelope.CommandText = comandoSql;
            //Colocando o envelope no canal de conexão
            envelope.Connection = con;
            //Colocar os valores vindo da tela no UPDATE
            envelope.Parameters.AddWithValue("@nomecurso", cursodto.Nomecurso);
            envelope.Parameters.AddWithValue("@turma", cursodto.Turma);
            envelope.Parameters.AddWithValue("@tipo", cursodto.Tipo);
            envelope.Parameters.AddWithValue("@status", cursodto.Status);
            envelope.Parameters.AddWithValue("@idcurso", cursodto.IdCurso);
            envelope.Prepare();
            int resultado = envelope.ExecuteNonQuery();
            //Fechar o canal de comunicação
            con.Close();
            if (resultado > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
