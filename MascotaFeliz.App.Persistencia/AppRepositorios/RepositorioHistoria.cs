using System;
using System.Collections.Generic;
using System.Linq;
using MascotaFeliz.App.Dominio;
using Microsoft.EntityFrameworkCore;


namespace MascotaFeliz.App.Persistencia
{
    public class RepositorioHistoria : IRepositorioHistoria
    {
        /// <summary>
        /// Referencia al contexto de Historia
        /// </summary>
        private readonly AppContext _appContext;
        /// <summary>
        /// Metodo Constructor Utiiza 
        /// Inyeccion de dependencias para indicar el contexto a utilizar
        /// </summary>
        /// <param name="appContext"></param>//
        
        public RepositorioHistoria(AppContext appContext)
        {
            _appContext = appContext;
        }

        public Historia AddHistoria(Historia historia)
        {
            var historiaAdicionado = _appContext.Historias.Add(historia);
            _appContext.SaveChanges();
            return historiaAdicionado.Entity;
        }

        public void DeleteHistoria(int idHistoria)
        {
            var historiaEncontrado = _appContext.Historias.FirstOrDefault(h => h.Id == idHistoria);
            if (historiaEncontrado == null)
                return;
            _appContext.Historias.Remove(historiaEncontrado);
            _appContext.SaveChanges();
        }

       public IEnumerable<Historia> GetAllHistorias()
        {
            return GetAllHistorias_();
        }

        public IEnumerable<Historia> GetAllHistorias_()
        {
            return _appContext.Historias;
        }

                   
     
        public Historia GetHistoria(int idHistoria)
        {
            return _appContext.Historias.FirstOrDefault(h => h.Id == idHistoria);
        }

        public Historia UpdateHistoria(Historia Historia)
        {
            var historiaEncontrado = _appContext.Historias.FirstOrDefault(h => h.Id == Historia.Id);
            if (historiaEncontrado != null)
            {
                historiaEncontrado.FechaInicial = Historia.FechaInicial;
                historiaEncontrado.VisitasPyP = Historia.VisitasPyP;
                
                _appContext.SaveChanges();
            }
            return historiaEncontrado;
        }     
    }
}