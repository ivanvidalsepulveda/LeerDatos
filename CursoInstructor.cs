using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace LeerDatos
{
    public class CursoInstructor
    {
        

        [Key]
        public int InstructorId {get;set;}

        [Key]
        public int CursoId {get;set;}

        public Instructor Instructor{get;set;}
        public Curso   Curso{get;set;}


    }



}