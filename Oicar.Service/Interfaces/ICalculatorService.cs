using Oicar.Service.Models;

namespace Oicar.Service.Interfaces
{
    public interface ICalculatorService
    {
        CloudCombinationResultDTO Calculate(CloudCombinationDTO cloudCombinationDTO);
    }
}
