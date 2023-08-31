using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faculdade.Classes
{
    internal class Aluno
    {
        private string nome;
        private Disciplina disciplina;
        private float nota1;
        private float nota2;
        private float media;
        private int faltas = 0;
        private string status = "Cursando";
        private bool IsSemestreFinalizado = false;

        public Aluno(String nome, Disciplina disciplina)
        {
            this.nome = nome;
            this.disciplina = disciplina;
            faltas = 0;
            status = "Cursando";
        }

        public float Nota1 { get { return nota1; } set { nota1 = value; } }
        public float Nota2 { get { return nota2; } set { nota2 = value; } }
        public float Media { get { return media; } }
        public int Faltas { get { return faltas; } }
        public string Status { get { return status; } }

        public void calcularMedia()
        {
            float media = (this.nota1 + this.nota2) / 2;
            this.media = media;
        }

        public void atribuirFalta()
        {
            faltas++;
        }

        public void abonarFalta()
        {
            faltas--;
        }

        public String verificarStatus()
        {
            if (faltas > disciplina.CargaHoraria * 0.25)
            {
                status = "Reprovado";
                return status;
            }
            else
            {
                if (media >= 7)
                {
                    IsSemestreFinalizado = true;
                    status = "Aprovado";
                    return status;
                }
                else
                {
                    status = "Reprovado";
                    return status;
                }
            }
        }


    }
}
