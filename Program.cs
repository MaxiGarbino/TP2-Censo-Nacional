using System.Collections.Generic;

Dictionary<int, Persona> personas = new Dictionary<int, Persona>();


int menu;
menu = Funciones.IngresarEnteroEnRango("Ingrese la opcion: 1.Cargar nueva persona   2. Obtener Estadisticas del Censo   3.Buscar Persona  4.Modificar Mail de una Persona   5.Salir", 0,6);
do{
    switch (menu){
    case 1:
        
        break;
    case 2:
        
        break;
    case 3:
        
        break;
    case 4:
        
        break;
    }
}while(menu != 5);

void CargarPersona(){
    int DNI;
    bool validar;
    do{
    DNI = Funciones.IngresarEntero("Ingresar DNI");
    validar = !personas.ContainsKey(DNI);
    } while (!validar);
    string apellido = Funciones.IngresarTexto("Ingresar apellido");
    string nombre = Funciones.IngresarTexto("Ingresar nombre");
    DateTime fechaNacimiento = Funciones.IngresarFecha("Ingresar fecha de nacimiento aaaa/mm/dd");
    string email = Funciones.IngresarTexto("Ingresar Email");
    Persona persona1 = new Persona(DNI, apellido, nombre, fechaNacimiento, email);
    personas.Add(DNI, persona1);
    Console.WriteLine($"Se ha creado la persona {nombre} {apellido} y se ha agregado a la lista.");
}

void ModificarMail(){
    int DNI;
    bool validar;
    DNI = Funciones.IngresarEntero("Ingresar DNI");
    validar = !personas.ContainsKey(DNI);
    while(!validar){
        Console.WriteLine("No se encuentra el DNI");
        DNI = Funciones.IngresarEntero("Ingresar DNI");
        validar = !personas.ContainsKey(DNI);
    }
    personas[DNI].Email = Funciones.IngresarTexto("Ingresar nuevo mail");
}