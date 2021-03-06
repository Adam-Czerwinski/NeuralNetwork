﻿using System;

namespace NeuralNetwork.ActivationFunctions
{
    internal class TanHActivationFunction : IActivationFunction
    {
        public float Calculate(float value)
        {
            return (float)Math.Tanh(value);
        }

        public float CalculateDerivative(float value)
        {
            return 1 - (value * value);
        }
    }
}
