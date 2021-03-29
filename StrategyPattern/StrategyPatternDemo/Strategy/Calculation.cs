﻿using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPatternDemo
{
    class Calculation
    {
        private ICalculationStrategy _strategy;

        // Constructor

        public Calculation(ICalculationStrategy strategy)
        {
            _strategy = strategy;
        }

        public void CalculationInterface(double num1, double num2)
        {
            _strategy.Calculate(num1, num2);
        }
    }
}
