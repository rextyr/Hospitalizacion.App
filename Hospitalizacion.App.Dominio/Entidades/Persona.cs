namespace Hospitalizacion.App.Dominio
{
    public class Persona
    {
         public int Id { get; set; }
      public string Nombre { get; set; }
      public string Apellido { get; set; }
      public int Numero { get; set; }
      public Genero Genero { get; set; }
    }
}