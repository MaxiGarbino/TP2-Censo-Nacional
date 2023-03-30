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
    case 5:
        
        break;
    }
}while(menu != 5);

void CargarPersona(){
    int DNI = Funciones.IngresarEntero("Ingresar DNI");
    string apellido = Funciones.IngresarTexto("Ingresar apellido");
    string nombre = Funciones.IngresarTexto("Ingresar nombre");
    DateTime fechaNacimiento = Funciones.IngresarFecha("Ingresar fecha de nacimiento aaaa/mm/dd");
    string email = Funciones.IngresarTexto("Ingresar Email");
}