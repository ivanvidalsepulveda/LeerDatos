using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;


namespace LeerDatos
{
    public class Curso
    {

        [Key]
         public int CursoId{get;set;}
         
        public string Titulo{get;set;}

        public string Descripcion {get;set;}

        public DateTime FechaPublicacion{get;set;}

        public Precio PrecioPromocion {get;set;}
        public ICollection<Comentarios> ComentarioLista {get;set;}

       public ICollection<CursoInstructor> InstructorLink {get;set;}



    }
    }
