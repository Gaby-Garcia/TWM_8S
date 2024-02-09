using TECNM.Practica2.Core.Entities;
using TECNM.Practica2.Core.Services.Interfaces;

namespace TECNM.Practica2.Core.Services;

public class NwService : INwService{
    public Nw ProcessNw(Person person){

        var nw = new Nw();
        nw.Index = (float)((person.Weight/9.81) * 3.711);

        return nw;  
     }
}