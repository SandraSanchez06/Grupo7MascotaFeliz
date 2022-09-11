using System;
using System.Collections.Generic;
using System.Linq;
using MascotaFeliz.App.Dominio;
using Microsoft.EntityFrameworkCore;

namespace MascotaFeliz.App.Persistencia
{
    public class RepositorioVeterinario : IRepositorioVeterinario
    {
        /// <summary>
        /// Referencia al contexto de Veterinario
        /// </summary>
        private readonly AppContext _appContext;
        /// <summary>
        /// Metodo Constructor Utiiza 
        /// Inyeccion de dependencias para indicar el contexto a utilizar
        /// </summary>
        /// <param name="appContext"></param>//
        
        public RepositorioVeterinario(AppContext appContext)
        {
            _appContext = appContext;
        }

        public Veterinario AddVeterinario(Veterinario Veterinario)
        {
            var VeterinarioAdicionado = _appContext.Veterinarios.Add(Veterinario);
            _appContext.SaveChanges();
            return VeterinarioAdicionado.Entity;
        }

        public void DeleteVeterinario(int idVeterinario)
        {
            var VeterinarioEncontrado = _appContext.Veterinarios.FirstOrDefault(v => v.Id == idVeterinario);
            if (VeterinarioEncontrado == null)
                return;
            _appContext.Veterinarios.Remove(VeterinarioEncontrado);
            _appContext.SaveChanges();
        }

       public IEnumerable<Veterinario> GetAllVeterinarios()
        {
            return GetAllVeterinarios_();
        }

        public IEnumerable<Veterinario> GetVeterinariosPorFiltro(string filtro)
        {
            var Veterinarios = GetAllVeterinarios(); // Obtiene todos los saludos
            if (Veterinarios != null)  //Si se tienen saludos
            {
                if (!String.IsNullOrEmpty(filtro)) // Si el filtro tiene algun valor
                {
                    Veterinarios = Veterinarios.Where(s => s.Nombres.Contains(filtro));
                }
            }
            return Veterinarios;
        }

        public IEnumerable<Veterinario> GetAllVeterinarios_()
        {
            return _appContext.Veterinarios;
        }

        public Veterinario GetVeterinario(int idVeterinario)
        {
            return _appContext.Veterinarios.FirstOrDefault(v => v.Id == idVeterinario);
        }

        public Veterinario UpdateVeterinario(Veterinario Veterinario)
        {
            var VeterinarioEncontrado = _appContext.Veterinarios.FirstOrDefault(v => v.Id == Veterinario.Id);
            if (VeterinarioEncontrado != null)
            {
                VeterinarioEncontrado.Nombres = Veterinario.Nombres;
                VeterinarioEncontrado.Apellidos = Veterinario.Apellidos;
                VeterinarioEncontrado.Direccion = Veterinario.Direccion;
                VeterinarioEncontrado.Telefono = Veterinario.Telefono;
                VeterinarioEncontrado.TarjetaProfesional = Veterinario.TarjetaProfesional;
                _appContext.SaveChanges();
            }
            return VeterinarioEncontrado;
        }     
    }
}