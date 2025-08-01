using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCursos.Model.DTO
{
    internal class CursoDTO
    {
        private int idCurso;
        private string nomecurso;
        private string turma;
        private string tipo;
        private string status;

        public CursoDTO()
        {
            
        }
        public CursoDTO(int idCurso, string nomecurso, string turma, string tipo, string status)
        {
            this.idCurso = idCurso;
            this.nomecurso = nomecurso;
            this.turma = turma;
            this.tipo = tipo;
            this.status = status;
        }

        public CursoDTO(string nomecurso, string turma, string tipo, string status)
        {
            this.nomecurso = nomecurso;
            this.turma = turma;
            this.tipo = tipo;
            this.status = status;
        }

        public int IdCurso { get => idCurso; set => idCurso = value; }
        public string Nomecurso { get => nomecurso; set => nomecurso = value; }
        public string Turma { get => turma; set => turma = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public string Status { get => status; set => status = value; }
    }
}
