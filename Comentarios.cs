using System.ComponentModel.DataAnnotations;
namespace LeerDatos
{
    public class Comentarios
    {
          [Key]
                public int ComentaroId {get;set;}
        public string Alumno {get;set;}

        public int Puntaje {get;set;}

        public string ComentarioTexto {get;set;}

        public int CursoId {get;set;}

        public Curso Curso {get;set;}


    }
}