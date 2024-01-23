using ActUsuario;

Usuario IngresarUsuario = new Usuario("Jorge", "Luis", 12345678, "Example1@gmail.com", 22, "Ravioles1234");
Usuario IngresarUsuario2 = new Usuario("Pablo", "Gil", 87654321, "Example2@hotmail.com", 15, "Empanadas1234");

IngresarUsuario.MostrarDatos();
IngresarUsuario.EsMayorDeEdad();
IngresarUsuario2.EsMayorDeEdad();
IngresarUsuario.EsGmail();
IngresarUsuario2.EsGmail();
IngresarUsuario.CambiarDireccion();

Console.ReadKey();