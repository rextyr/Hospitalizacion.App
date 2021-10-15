using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Hospitalizacion.App.Dominio;
using Hospitalizacion.App.Persistencia;

namespace Hospimascotas.App.Frontend.Pages.Auxiliares
{
    public class RegistroAuxModel : PageModel
    {
        private readonly IRepositorioPersonas _repositorioPersonas;
        public AuxiliarVeterinario auxiliar { get; set; }

        public RegistroAuxModel(IRepositorioPersonas _repositorioPersonas )
        {
            this._repositorioPersonas=_repositorioPersonas;
        }

        public void OnGet()
        {
              auxiliar= new AuxiliarVeterinario();
        }

        public IActionResult OnPost(AuxiliarVeterinario auxiliar )
        {

            _repositorioPersonas.AddPersona(auxiliar);
            return RedirectToPage("ListaAuxiliares");
        }
        
        
    }
}
