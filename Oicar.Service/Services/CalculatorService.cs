using Oicar.Dal;
using Oicar.Dal.Interfaces;
using Oicar.Service.Interfaces;
using Oicar.Service.Models;

namespace Oicar.Service.Services
{
    public class CalculatorService : ICalculatorService
    {
        private IUnitOfWork _uow;

        public CalculatorService(OicarContext context)
        {
            _uow = new UnitOfWork(context);
        }

        public CloudCombinationResultDTO Calculate(CloudCombinationDTO cloudCombinationDTO)
        {
            return new CloudCombinationResultDTO();
        }
    }
}
