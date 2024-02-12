// See https://aka.ms/new-console-template for more information
Console.WriteLine("Entrada Discoteca");
Console.WriteLine();

{
    // Pedir al usuario que ingrese la edad y el género
    Console.WriteLine("Ingrese la edad:");
    int edad = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Ingrese el género (hembra o varón):");
    string genero = Console.ReadLine();

    // Llamar al método y mostrar el resultado en pantalla
    string resultado = VerificarEntradaDiscoteca(edad, genero);
    Console.WriteLine(resultado);
}

static string VerificarEntradaDiscoteca(int edad, string genero)
{
   
    if (edad < 18)
    {
        return "Lo siento, eres menor de edad y no puedes entrar a la discoteca.";
    }

   
    if (genero.ToLower() == "hembra")
    {
        return "Bienvenida, puedes entrar gratis.";
    }
    else if (genero.ToLower() == "varón")
    {
        return "Bienvenido, puedes entrar pagando.";
    }
    else
    {
        return "Género no reconocido. Por favor, ingrese 'hembra' o 'varón'.";
    }
}
   