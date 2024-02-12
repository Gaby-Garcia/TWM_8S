using System;
using TECNM.Practica2.Core.Entities;
using TECNM.Practica2.Core.Managers;
using TECNM.Practica2.Core.Services;

namespace TECNM.Practica2.App;

public static class Program{
    public static void Main(String[] args ){

        float weight = 0;

        System.Console.Write("Ingresa tu peso en Kg: ");
        Single.TryParse(System.Console.ReadLine(), out weight);

        //Instancia a clase Persona y Newton-weight
        var person = new Person{Weight = weight};

        var service = new NwService();
        var managers = new NwManager(service);

        Nw nw = managers.GetNw(person);

        System.Console.WriteLine($"Tu peso en Marte es de: {nw.Index} Kg");
    }
}
