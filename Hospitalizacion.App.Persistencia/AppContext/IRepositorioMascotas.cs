using System.Collections.Generic;
using Hospitalizacion.App.Dominio;
using System.Linq;

namespace Hospitalizacion.App.Persistencia
{
    public interface IRepositorioMascotas
    {
        IEnumerable<MascotaEnferma> GetAllMascotasEnfermas();
        MascotaEnferma AddMascotaEnferma(MascotaEnferma mascotaEnferma);
         MascotaEnferma UpdateMascotaEnferma(MascotaEnferma mascotaEnferma);
        void DeleteMascotaEnferma (int idMascotaEnferma);
        MascotaEnferma GetMascotaEnferma(int idMascotaEnferma);
        
    } 
}