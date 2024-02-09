using TECNM.Practica2.Core.Entities;
using TECNM.Practica2.Core.Managers.Interfaces;
using TECNM.Practica2.Core.Services.Interfaces;

namespace TECNM.Practica2.Core.Managers;

public class NwManager : INwManager{

    private readonly INwService _service;

    public NwManager(INwService service){
        _service = service;
    }

    public Nw GetNw(Person person){
        return _service.ProcessNw(person);
    }
}