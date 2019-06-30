using ContractApi.Classes;
using System;

namespace ContractApi.Models.Contracts
{
    public abstract class Contract
    {
        protected readonly Random _random;

        public Contract()
        {
            _random = new Random();
        }

        public string Name
        {
            get
            {
                return RandomWordGenerator.GetRandomWord(10);
            }
        }

        public int Price
        {
            get
            {
                return _random.Next(1, 1000);
            }
        }
    }
}
