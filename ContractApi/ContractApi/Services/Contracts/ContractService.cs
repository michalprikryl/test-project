using ContractApi.Models.Contracts;

namespace ContractApi.Services.Contracts
{
    public class ContractService : IContractService
    {
        public Contract GetContract(bool heat = true)
        {
            if (heat)
            {
                return new HeatContract();
            }
            else
            {
                return new ElectricityContract();
            }
        }
    }
}
