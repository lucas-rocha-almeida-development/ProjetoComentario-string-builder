using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoComentario_string_builder.Entitides
{
    internal class Postagem
    {
        public DateTime Moment { get; set; }//momento
        public string Title { get; set; }//titulo

        public string Content { get; set;}//conteudo

        public int Likes { get; set; }//linkes (curtidas)

        public List<Comentario> Comments { get; set; } = new List<Comentario>();

        //criação dos construtores

        public Postagem() { 
            //Construtor padrão sem argumentos
        }

        public Postagem(DateTime moment, string title, string content, int likes)
        {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = likes;
        }
        //metodo de adicionar comentario
        public void AddComentario (Comentario comentario)
        {
            Comments.Add(comentario);
        }
        //metodo de remover comentario
        public void RemoveComentario (Comentario comentario)
        {
            Comments.Remove(comentario);
        }
        public override string ToString()
        {// vamos utilizar string Builder
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Title);
            sb.Append(Likes);
            sb.Append(" Likes - ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine(Content);
            sb.Append("Comentario: ");
            //adicionar o texto no comentario, teremos que percorrer a lista
            foreach(Comentario c in Comments)
            {
                sb.AppendLine(c.Text);
            }
            return sb.ToString();//converter conteudo do stringBuilder para string

        }
    }
}
