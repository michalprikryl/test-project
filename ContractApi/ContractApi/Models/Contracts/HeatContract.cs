using System;

namespace ContractApi.Models.Contracts
{
    public class HeatContract : Contract
    {
        public double[] Temperatures
        {
            get
            {
                int countOfTemperatures = _random.Next(5, 11);
                double[] temperatures = new double[countOfTemperatures];
                for (int i = 0; i < countOfTemperatures; i++)
                {
                    temperatures[i] = Math.Round((_random.NextDouble() * 10) + 20, 1);
                }
                return temperatures;
            }
        }
    }
}
