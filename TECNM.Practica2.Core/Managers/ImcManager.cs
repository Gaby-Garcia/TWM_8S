using TECNM.Practica2.Core.Entities;
using TECNM.Practica2.Core.Managers.Interfaces;
using TECNM.Practica2.Core.Services.Interfaces;

namespace TECNM.Practica2.Core.Managers;

public class ImcManager : IImcManager{

    private readonly IImcService _service;

    public ImcManager(IImcService service){
        _service = service;
    }

    public Imc GetImc(Person person){
        return _service.ProcessImc(person);
    }
}