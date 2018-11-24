using System;
using System.Collections.Generic;
using System.Text;

namespace TipCalc.Core.Services
{
    public class CalculationService : ICalculationService
    {
        public double TipAmount(double subTotal, int generousity)
        {
            return subTotal * ((double)generousity) / 100.0;
        }
    }
}
