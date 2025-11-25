using System;

class Program
{
    static void Main(string[] args)
    {
       
        Computadora maquina = new Computadora("Alex");

        maquina.Prender();
        maquina.EnviarMensaje("Hola, soy una maquina.");
        maquina.Apagar();

        
    }
}



