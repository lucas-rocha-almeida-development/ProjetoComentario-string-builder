using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoComentario_string_builder.Entitides;

namespace ProjetoComentario_string_builder
{
    internal class Program
    {
        static void Main(string[] args)
        { //primeira Postagem
            Comentario c1 = new Comentario("Tenha uma boa viagem!! ");
            Comentario c2 = new Comentario("Uau, isso e incrivel!! ");
            Postagem p1 = new Postagem(DateTime.Parse("12/12/2012 01:00"), "Viajando para Las Vegas!!",
                "Eu irei conhecer esse Pais maravilhoso!!", 12);
            p1.AddComentario(c1);
            p1.AddComentario(c2);

            //segunda Postagem
            Comentario c3 = new Comentario("Boa noite!! ");
            Comentario c4 = new Comentario("Tenha um excelente descanso!! ");
            Postagem p2 = new Postagem(DateTime.Parse("10/01/2013 01:00"), "Grande Noite Amigos!!",
                "Nos vemos amanhã!!", 5);
            p2.AddComentario(c3);
            p2.AddComentario(c4);
            //VAMOS IMPRIMIR AS POSTAGEM COM COMENTARIOS
            Console.WriteLine(p1);
            Console.WriteLine(p2);

        }
    }
}
