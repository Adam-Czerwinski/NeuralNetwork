using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetwork.ActivationFunctions
{
    internal class SwishActivationFunction :IActivationFunction
    {
        private SigmoidActivationFunction sigmoid = new SigmoidActivationFunction();
        public float Calculate(float value)
        {
            return sigmoid.Calculate(value) * value;
        }

        public float CalculateDerivative(float value)
        {
            var val = sigmoid.Calculate(value);
            return value * val * (1 - val) + val;
        }
    }
}
