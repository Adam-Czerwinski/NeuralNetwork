using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetwork.ActivationFunctions
{
    internal interface IActivationFunction
    {
        float Calculate(float value);
        float CalculateDerivative(float value);
    }
}
