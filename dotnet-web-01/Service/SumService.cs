using System;
using DOTNET_WEB_01.Models;

namespace DOTNET_WEB_01.Service
{
    public class SumService
    {
        private void IsValidate(InputValuesSum requestInput)
        {
            if (requestInput.Operating == 0 || requestInput.Operator == 0)
                throw new Exception("Valores de entrada não podem ser iguais a 0");
        }

        public decimal Calculator(InputValuesSum requestInput)
        {
            IsValidate(requestInput);

            return requestInput.Operator + requestInput.Operating; 
        }
    }
}