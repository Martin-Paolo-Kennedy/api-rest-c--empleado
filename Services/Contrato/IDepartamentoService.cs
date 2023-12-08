using Gestion_Farmacia_martin.Models;

namespace Gestion_Farmacia_martin.Services.Contrato
{
    public interface IDepartamentoService
    {
        Task<List<Departamento>> GetList();
    }
}
