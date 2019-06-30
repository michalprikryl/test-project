using System;

namespace ContractApi.Models.Contracts
{
    public class ElectricityContract : Contract
    {
        public string BuildingType
        {
            get
            {
                return Enum.GetName(typeof(BuildingTypeEnum), _random.Next(0, 3));
            }
        }
    }

    public enum BuildingTypeEnum
    {
        Flat, House, Other
    }
}
