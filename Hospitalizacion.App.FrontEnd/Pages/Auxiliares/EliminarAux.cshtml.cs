using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Hospitalizacion.App.Persistencia;
using Hospitalizacion.App.Dominio;


namespace Hospimascotas.App.Frontend.Pages.Auxiliares
{
    public class EliminarAuxModel : PageModel
    {

       public readonly IRepositorioPersonas _repositorioPersona;

       public AuxiliarVeterinario auxiliar { get; set; }

       public EliminarAuxModel(IRepositorioPersonas _repositorioPersona)
       {
           this._repositorioPersona=_repositorioPersona;
       }
        public IActionResult OnGet(int id)
        {
            auxiliar=_repositorioPersona.GetAuxiliar(id);
            if (auxiliar==null)
            {
                return NotFound();
            }else{

                return Page();
            }
        }
        public IActionResult OnPost(int id)
        {
            _repositorioPersona.DeletePersona(id);
            return RedirectToPage("ListaAuxiliares");
        }
    }
}
