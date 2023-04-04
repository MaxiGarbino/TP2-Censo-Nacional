using System.Collections.Generic;

Dictionary<int, Persona> personas = new Dictionary<int, Persona>();


int menu;

do{
    menu = Funciones.IngresarEnteroEnRango("Ingrese la opcion: 1.Cargar nueva persona   2. Obtener Estadisticas del Censo   3.Buscar Persona  4.Modificar Mail de una Persona   5.Salir ", 0,6);
    switch (menu){
    case 1:
        CargarPersona();
        break;
    case 2:
        ObtenerEstadisticasCenso();
        break;
    case 3:
        int dni = 0;
        dni = Funciones.IngresarEntero("Ingresar DNI a buscar: ");
        BuscarPersona(dni);
        break;
    case 4:
        ModificarMail();
        break;
    }
}while(menu != 5);

void ObtenerEstadisticasCenso(){
    Console.WriteLine("Estadisticas del Censo: ");
    Console.WriteLine("Cantidad de Personas: " + personas.Count());
    int acumEdad = 0;
    int personasQuePuedenVotar = 0;
    foreach (int dni in personas.Keys)
    {
        if(personas[dni].PuedeVotar()){
            personasQuePuedenVotar++;
        }

    }
    foreach(int dni in personas.Keys){
        acumEdad += personas[dni].ObtenerEdad();
    }
    Console.WriteLine($"Cantidad de personas habilitadas para votar : {personasQuePuedenVotar}");
    
    if(personas.Count() > 0){
        Console.WriteLine("Edad promedio: " + acumEdad/personas.Count());
    }
    else{
        Console.WriteLine("Edad promedio: ");
    }
    
    
}

void BuscarPersona(int dni){
    if(personas.ContainsKey(dni)){
        Console.WriteLine(personas[dni].Nombre);
        Console.WriteLine(personas[dni].Apellido);
        Console.WriteLine(personas[dni].FechaNacimiento);
        Console.WriteLine(personas[dni].Email);
        if(personas[dni].PuedeVotar())Console.WriteLine("Puede votar");
        else Console.WriteLine("No puede votar");
    }
    else Console.WriteLine("No se encuenta el DNI");
}

void CargarPersona(){
    int DNI;
    bool validar;
    do{
    DNI = Funciones.IngresarEntero("Ingresar DNI: ");
    validar = !personas.ContainsKey(DNI);
    } while (!validar);
    string apellido = Funciones.IngresarTexto("Ingresar apellido: ");
    string nombre = Funciones.IngresarTexto("Ingresar nombre: ");
    DateTime fechaNacimiento = Funciones.IngresarFecha("Ingresar fecha de nacimiento aaaa/mm/dd: ");
    string email = Funciones.IngresarTexto("Ingresar Email: ");
    Persona persona1 = new Persona(DNI, apellido, nombre, fechaNacimiento, email);
    personas.Add(DNI, persona1);
    Console.WriteLine($"Se ha creado la persona {nombre} {apellido} y se ha agregado a la lista.");
}

void ModificarMail(){
    int DNI;
    bool validar;
    DNI = Funciones.IngresarEntero("Ingresar DNI: ");
    validar = personas.ContainsKey(DNI);
    while(!validar){
        Console.WriteLine("No se encuentra el DNI");
        DNI = Funciones.IngresarEntero("Ingresar DNI");
        validar = personas.ContainsKey(DNI);
    }
    personas[DNI].Email = Funciones.IngresarTexto("Ingresar nuevo mail");
}