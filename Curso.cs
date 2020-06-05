using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using System.ComponentModel.DataAnnotations;

namespace LeerDatos
{
    public class Curso
    {

        [Key]
         public int CursoId{get;set;}
         
        public string Titulo{get;set;}

        public string Descripcion {get;set;}

        public DateTime FechaPublicacion{get;set;}

    }
}