using System.Collections.Generic;
using Hospitalizacion.App.Dominio;
using System.Linq;

namespace Hospitalizacion.App.Persistencia
{
    public interface IRepositorioSignosVitales
    {
        IEnumerable<SignosVitales> GetAllSignosVitales();
        SignosVitales AddSignosVitales(SignosVitales signo);
        SignosVitales UpdateSignosVitales(SignosVitales signo);
        void DeleteSignosVitales (int idSignosVitales);
        SignosVitales GetSignosVitales(int idSignosVitales);
    }
}