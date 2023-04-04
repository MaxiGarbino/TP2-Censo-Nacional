using System;
class Persona
{
    // Definicion de Propiedades
    public int DNI{get;private set;}
    public string Apellido{get;set;}
    public string Nombre{get;set;}
    public DateTime FechaNacimiento{get;set;}
    public string Email{get;set;}
// Constructor
public Persona()
{

}
    public Persona(int dni=0, string apellido = "No se ingreso apellido", string nombre="No se ingreso nombre", DateTime fn = new DateTime(), string email = "No se ingreso Email")
    {
        Nombre = nombre;
        DNI=dni;
        Apellido=apellido;
        FechaNacimiento = fn;
        Email=email;

    }

    // Métodos

    public int ObtenerEdad()
    {
        int edad = 0;
        DateTime FechaNacimientoHoy = new DateTime(DateTime.Today.Year, FechaNacimiento.Month, FechaNacimiento.Day);
        if (FechaNacimientoHoy< DateTime.Today)  edad = DateTime.Today.Year - FechaNacimiento.Year;
            else   edad = DateTime.Today.Year - FechaNacimiento.Year -1;
        return edad; 
    }
    public bool PuedeVotar(){
        bool puedeVotar;
        const int EdadMinima = 16;
        if(ObtenerEdad() >= EdadMinima) puedeVotar = true;
        else puedeVotar = false;
        return puedeVotar;
    }
}