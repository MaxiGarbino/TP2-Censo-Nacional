using System;
class Persona
{
    // Definicion de Propiedades
    public int DNI{get;private set;}
    public int Apellido{get;set;}
    public string Nombre{get;set;}
    public string Curso{get;set;}
    public DateTime FechaNacimiento{get;set;}
    private int Edad{get;set;}
// Constructor
public Alumnx()
{

}
    public Alumnx(string nom, int dni=0, string cur="", DateTime fn = new DateTime())
    {
        Nombre = nom;
        DNI=dni;
        Curso=cur;
        FechaNacimiento = fn;
        Edad=0;
    }

    // Métodos

    public int MiEdad()
    {
        DateTime FechaNacimientoHoy = new DateTime(DateTime.Today.Year, FechaNacimiento.Month, FechaNacimiento.Day);
        if (FechaNacimientoHoy< DateTime.Today)  Edad = DateTime.Today.Year - FechaNacimiento.Year;
            else   Edad = DateTime.Today.Year - FechaNacimiento.Year -1;
        return Edad; 
    }
}