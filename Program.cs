﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;


namespace LeerDatos
{
    class Program
    {
        static void Main(string[] args)
        {
          
            using(var db= new AppVentaCursosContext()){

                /*  var cursos = db.Curso.AsNoTracking();
                foreach(var curso in cursos){
                    Console.WriteLine(curso.Titulo +"----" +curso.Descripcion + "---" + curso.FechaPublicacion);
                */

               /* var cursos = db.Curso.Include(p => p.PrecioPromocion).AsNoTracking();

                foreach (var curso in cursos){

                    Console.WriteLine(curso.Titulo+ "--"+ curso.PrecioPromocion.PrecioActual);

                    
                }*/
                        /*
                var cursos = db.Curso.Include(c => c.ComentarioLista).AsNoTracking();
                foreach(var curso in cursos){

                    Console.WriteLine(curso.Titulo);
                    foreach(var comentario in curso.ComentarioLista){
                        Console.WriteLine("*********"+ comentario.ComentarioTexto);




                    }
                }  */
                        var cursos = db.Curso.Include(c=>c.InstructorLink).ThenInclude(ci=>ci.Instructor);
                        foreach(var curso in cursos){

                            Console.WriteLine("Curso: " +curso.Titulo);
                            foreach(var insLink in curso.InstructorLink){
                                    Console.WriteLine("Alumno: " + insLink.Instructor.Nombre + " " +insLink.Instructor.Apellido  + " " + insLink.Instructor.Grado);

                            }
                        }
                }
            }


        }
    }
