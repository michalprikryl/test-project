using ContractApi.Models.Contracts;
using ContractApi.Services.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace ContractApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ContractController : ControllerBase
    {
        private readonly IContractService _contractService;

        public ContractController(IContractService contractService)
        {
            _contractService = contractService;
        }

        [HttpGet("electricity/{id}")]
        public ActionResult<Contract> Electricity(int id)
        {
            return _contractService.GetContract(false);
        }

        [HttpGet("heat/{id}")]
        public ActionResult<Contract> Heat(int id)
        {
            return _contractService.GetContract();
        }
    }
}
