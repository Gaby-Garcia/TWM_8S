using TECNM.Practica2.Core.Entities;
using TECNM.Practica2.Core.Services.Interfaces;

namespace TECNM.Practica2.Core.Services;

public class ImcService : IImcService{
    public Imc ProcessImc(Person person){

        var imc = new Imc();
        imc.Index = (float)((person.Weight/9.81) * 3.711);

        return imc;  
     }
}