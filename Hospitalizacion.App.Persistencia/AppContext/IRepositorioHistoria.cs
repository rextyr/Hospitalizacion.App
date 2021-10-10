using System.Collections.Generic;
using Hospitalizacion.App.Dominio;
using System.Linq;

namespace Hospitalizacion.App.Persistencia
{
    public interface IRepositorioHistoria
    {
          IEnumerable<Historia> GetAllHistoria();
        Historia AddHistoria(Historia historia);
        Historia UpdateHistoria(Historia historia);
        void DeleteHistoria (int idHistoria);
        Historia GetHistoria(int idHistoria);
    }
}