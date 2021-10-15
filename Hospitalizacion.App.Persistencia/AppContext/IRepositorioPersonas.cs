using System.Collections.Generic;
using Hospitalizacion.App.Dominio;
using System.Linq;


namespace Hospitalizacion.App.Persistencia
{
    public interface IRepositorioPersonas
    {
        IEnumerable<Persona> GetAllPersona();
        IEnumerable<MedicoVeterinario> GetAllMedicoVeterinario();
        IEnumerable<Dueño> GetAllDueño();
         IEnumerable<AuxiliarVeterinario> GetAllAuxiliar();
        Persona AddPersona(Persona persona);
        Persona UpdatePersona(Persona persona);
        Dueño UpdateDueño(Dueño dueño);
        MedicoVeterinario UpdateMedicoVeterinario(MedicoVeterinario medicoVeterinario);
        AuxiliarVeterinario UpdateAuxiliarVeterinario(AuxiliarVeterinario auxiliarVeterinario);
        void DeletePersona (int idPersona);
        Persona GetPersona(int idPersona);
        MedicoVeterinario GetMedico(int idMedico);
        AuxiliarVeterinario GetAuxiliar(int idMedico);
    }
}