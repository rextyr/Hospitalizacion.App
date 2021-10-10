using System.Collections.Generic;
using Hospitalizacion.App.Dominio;
using System.Linq;

namespace Hospitalizacion.App.Persistencia
{
    public interface IRepositorioSugerenciaCuidado
    {
           IEnumerable<SugerenciaCuidado> GetAllSugerenciaCuidado();
        SugerenciaCuidado AddSugerenciaCuidado(SugerenciaCuidado sugerenciaCuidado);
        SugerenciaCuidado UpdateSujerenciaCuidado(SugerenciaCuidado sugerenciCuidado);
        void DeleteSugerenciaCuidado (int idSugerenciaCuidado);
        SugerenciaCuidado GetSugerenciaCuidado(int idSugerenciaCuidado);      


    }
}