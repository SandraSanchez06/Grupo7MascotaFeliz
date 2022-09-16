using System;
using MascotaFeliz.App.Dominio;
using MascotaFeliz.App.Persistencia;
using System.Collections.Generic;

namespace MascotaFeliz.App.Consola
{
    class Program
    {

        /*private static IRepositorioDueno _repoDueno = new RepositorioDueno(new Persistencia.AppContext());*/
        private static IRepositorioVeterinario _repoVeterinario = new RepositorioVeterinario(new Persistencia.AppContext());
        /*private static IRepositorioMascota _repoMascota = new RepositorioMascota(new Persistencia.AppContext());*/
        /*private static IRepositorioHistoria _repoHistoria = new RepositorioHistoria(new Persistencia.AppContext());
       private static IRepositorioVisitaPyP _repoVisitaPyP = new RepositorioVisitaPyP(new Persistencia.AppContext());*/
        static void Main(string[] args)
        {
            Console.WriteLine("Hola amigos vamos a empezar a trabajar con las tablas");

                       
            //ListarDuenosFiltro();      
            //AddDueno();
           // BuscarDueno(7);

           //ListarVeterinariosFiltro();
           AddVeterinario();
            //BuscarVeterinario(3);

            //ListarHistoriasFiltro();
            //AddHistoria();
            //BuscarHistoria(5);  

            //ListarMascotasFiltro();
            //AddMascota();
           //BuscarMascota(1);

            //ListarHistoriasFiltro();
            //AddHistoria();
            //BuscarHistoria(2);           
            
            //ListarVisitasPyPFiltro();
            //AddVisitaPyP();
            //BuscarVisitaPyP(1); 

        }

        /*private static void AddDueno()
        {
            var dueno = new Dueno
            {
                Nombres = "Jose Alejandro",
                Apellidos = "Martinez", 
                Direccion = "Carrera 67 # 23 67",
                Telefono = "3105670003",
                Correo = "josemartinez@gmail.com"
            };
            _repoDueno.AddDueno(dueno);
        }*/

        private static void AddVeterinario()
        {
            var veterinario = new Veterinario
            {
                Nombres = "Laura Camila",
                Apellidos = "Zarate ", 
                Direccion = "Calle 123 # 45 34",
                Telefono = "3134564564",
                TarjetaProfesional = "TP0093"
            };
            _repoVeterinario.AddVeterinario(veterinario);
        }
         
         
       /*private static void AddMascota()
        {
            var mascota = new Mascota
            {
                Nombre = "Lucas",
                Color = "Cafe", 
                Especie = "Canino",
                Raza = "Pastor Aleman",
                //Historia = 002,
                //Dueño = "Leonardo",
                //Veterinario = "La Chilindrina"
            };
            _repoMascota.AddMascota(mascota);
        }*/
       
        /*private static void AddVisitaPyP()
        {
            var visitaPyP = new VisitaPyP
            {
                Temperatura = 17,
                Peso = 14,
                FrecuenciaRespiratoria = 120, 
                FrecuenciaCardiaca = 80,
                EstadoAnimo = "buena"
                
            };
            _repoVisitaPyP.AddVisitaPyP(visitaPyP);
        }*/

       /* private static void AddHistoria()
        {
            var historia = new Historia
            {
                FechaInicial = new DateTime(2022, 09, 10)
                
            };
            _repoHistoria.AddHistoria(historia);
        }*/


        /*private static void BuscarDueno(int IdDueno)
          {
            var dueno = _repoDueno.GetDueno(IdDueno);
            Console.WriteLine(dueno.Nombres + " " + dueno.Apellidos+" "+dueno.Direccion+" "+dueno.Telefono+" "+dueno.Correo);
        }*/

        private static void BuscarVeterinario(int IdVeterinario)
        {
            var veterinario = _repoVeterinario.GetVeterinario(IdVeterinario);
            Console.WriteLine(veterinario.Nombres + " " + veterinario.Apellidos+" "+veterinario.Direccion+" "+veterinario.Telefono+" "+veterinario.TarjetaProfesional);
        }

       /*private static void BuscarMascota(int IdMascota)
        {
            var mascota = _repoMascota.GetMascota(IdMascota);
            Console.WriteLine(mascota.Nombre + " " + mascota.Color+" "+mascota.Especie+" "+mascota.Raza);
        }*/

         /*private static void BuscarHistoria(int idHistoria)
          {
            var historia = _repoHistoria.GetHistoria(idHistoria);
            Console.WriteLine(historia.Id + " " + historia.FechaInicial);
        }*/
        
        /*private static void BuscarVisitaPyP(int IdVisitaPyP)
        {
            var visitaPyP = _repoVisitaPyP.GetVisitaPyP(IdVisitaPyP);
            Console.WriteLine(visitaPyP.Temperatura + " " + visitaPyP.Peso +" "+ visitaPyP.FrecuenciaRespiratoria+" "+visitaPyP.FrecuenciaCardiaca+" "+visitaPyP.EstadoAnimo);
        }*/



        /*private static void ListarDuenosFiltro()
        {
            var duenosM = _repoDueno.GetAllDuenos();
            foreach (Dueno p in duenosM)
            {
                Console.WriteLine(p.Nombres + " " + p.Apellidos);
            }

        }*/

        private static void ListarVeterinariosFiltro()
        {
            var veterinariosM = _repoVeterinario.GetAllVeterinarios();
            foreach (Veterinario p in veterinariosM)
            {
                Console.WriteLine(p.Nombres + " " + p.Apellidos);
            }

        }

        /*private static void ListarMascotasFiltro()
        {
            var mascotasM = _repoMascota.GetAllMascotas();
            foreach (Mascota p in mascotasM)
            {
                Console.WriteLine(p.Nombre + " " + p.Color+" "+p.Especie+" "+p.Raza);
            }

        }*/

        /*private static void ListarHistoriasFiltro()
         {
            var historiasM = _repoHistoria.GetAllHistorias();
            foreach (Historia p in historiasM)
            {
                Console.WriteLine(p.Id + " " + p.FechaInicial);
            }

        }*/

        /*private static void ListarVisitasPyPFiltro()
        {
            var visitaPyPM = _repoVisitaPyP.GetAllVisitaPyP();
            foreach (VisitaPyP p in visitaPyPM)
            {
                Console.WriteLine(p.Temperatura + " " + p.Peso);
            }
        }*/
    }
    }

