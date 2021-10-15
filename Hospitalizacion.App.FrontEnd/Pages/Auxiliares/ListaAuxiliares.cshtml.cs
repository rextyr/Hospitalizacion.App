using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Hospitalizacion.App.Dominio;
using Hospitalizacion.App.Persistencia;

namespace Hospimascotas.App.Frontend.Pages
{
    public class ListaAuxiliaresModel : PageModel
    {
        private readonly IRepositorioPersonas _repositorioPersonas;
        public IEnumerable<AuxiliarVeterinario> Auxiliares { get; set; }
        

        public ListaAuxiliaresModel(IRepositorioPersonas _repositorioPersonas)
        {
            this._repositorioPersonas=_repositorioPersonas;
        }


        
        public void OnGet()
        {
            Auxiliares=_repositorioPersonas.GetAllAuxiliar();
        }
    }
}
