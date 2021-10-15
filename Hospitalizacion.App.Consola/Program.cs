using System;
using Hospitalizacion.App.Dominio;
using Hospitalizacion.App.Persistencia;
using System.Collections.Generic;

namespace Hospitalizacion.App.Consola
{
    class Program
    {
          private static IRepositorioMascotas _reporteMascota = new RepositorioMascotas (new Persistencia.AppContext());
         private static IRepositorioSignosVitales _reporteSignosVitales = new RepositorioSignosVitales (new Persistencia.AppContext());
          private static IRepositorioSugerenciaCuidado _reporteSugerenciaCuidado = new RepositorioSugerenciaCuidado (new Persistencia.AppContext());
      
         private static IRepositorioPersonas _reportePersonas = new RepositorioPersonas (new Persistencia.AppContext());

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            AuxiliarVeterinario nuevo =new AuxiliarVeterinario();{

                nuevo.Nombre= "miguel";
               nuevo.Apellido= "Enrique";
               nuevo.Numero=310187478;
               nuevo.Genero= Genero.Masculino; 
               nuevo.No_Certificado=4744;
               nuevo.HorasLaborales=10000;

               AgregarAuxiliar(nuevo);
            }   

        }

        public static void AgregarMedico(MedicoVeterinario medico){

          _reportePersonas.AddPersona(medico);
           Console.WriteLine("se ha guardado el registro");
        }

        public static void AgregarAuxiliar(AuxiliarVeterinario medico){

          _reportePersonas.AddPersona(medico);
           Console.WriteLine("se ha guardado el registro");
        }
        
  

        public  static void DeleteMedico(int id)
        {
            _reportePersonas.DeletePersona(id);
        }

      
        public static void GetAllMedico(int id,  List<MascotaEnferma> ListademascotasAcargo)
        {
            var medicoEncontrado = _reportePersonas.GetMedico(id);
            Console.WriteLine(medicoEncontrado.Nombre+"   "+medicoEncontrado.Apellido);
            
        }
    }
}
