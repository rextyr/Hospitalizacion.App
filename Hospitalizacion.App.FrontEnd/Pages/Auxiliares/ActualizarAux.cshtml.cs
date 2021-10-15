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
    public class ActualizarAuxModel : PageModel
    {
        public readonly IRepositorioPersonas _repositorioPersona;

       public AuxiliarVeterinario auxiliar { get; set; }

       public ActualizarAuxModel(IRepositorioPersonas _repositorioPersona)
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
        public IActionResult OnPost(AuxiliarVeterinario auxiliar)
        {
            _repositorioPersona.UpdatePersona(auxiliar);
            return RedirectToPage("ListaAuxiliares");
        }
    }
}
