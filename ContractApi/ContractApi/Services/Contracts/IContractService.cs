using ContractApi.Models.Contracts;

namespace ContractApi.Services.Contracts
{
    public interface IContractService
    {
        Contract GetContract(bool heat = true);
    }
}
