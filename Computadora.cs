using System;

public class Computadora : Maquina, IMensaje
{
    public Computadora(string nombre) : base(nombre)
    {
    }

    public override void Prender()
    {
        Console.WriteLine($"{Nombre} está encendida.");
    }

    public override void Apagar()
    {
        Console.WriteLine($"{Nombre} está apagada.");
    }

    public void EnviarMensaje(string mensaje)
    {
        Console.WriteLine($"{Nombre} envió un mensaje: {mensaje}");
    }
}