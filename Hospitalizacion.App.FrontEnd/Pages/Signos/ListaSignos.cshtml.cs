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
    public class ListaSignosModel : PageModel
    {

        private readonly  IRepositorioSignosVitales _reportesigno;

         public IEnumerable<SignosVitales> SignosVitalesl { get; set;}
         

         public ListaSignosModel(IRepositorioSignosVitales _reportesigno)
         {
             this._reportesigno=_reportesigno;
         }
                 
        public void OnGet()
        {
            SignosVitalesl=_reportesigno.GetAllSignosVitales();
        }
    }
}
