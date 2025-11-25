using System;

public abstract class Maquina
{
    public string Nombre { get; set; }

    public Maquina(string nombre)
    {
        Nombre = nombre;
    }

    public abstract void Prender();
    public abstract void Apagar();
}