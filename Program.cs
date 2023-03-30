using System.Collections.Generic;

Dictionary<int, Persona> personas = new Dictionary<int, Persona>();

void CargarPersona(){
    int DNI = Funciones.IngresarEntero("Ingresar DNI");
    string apellido = Funciones.IngresarTexto("Ingresar apellido");
    string nombre = Funciones.IngresarTexto("Ingresar nombre");
    DateTime fechaNacimiento = Funciones.IngresarFecha("Ingresar fecha de nacimiento aaaa/mm/dd");
    string email = Funciones.IngresarTexto("Ingresar Email");
}