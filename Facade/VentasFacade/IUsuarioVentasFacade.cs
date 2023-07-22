using Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.VentasFacade
{
    public interface IUsuarioVentasFacade
    {
        Task<List<FacturaDto>> FindFacturasByPersonaFacade(int id);

        Task<int> StoreFacturaFacade(RequestFacturaDto requestFacturaDto);
    }
}
