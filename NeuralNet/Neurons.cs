using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace NeuralNet
{
    class Neurons
    {
        double[] Neuron { get; set; }
        double[] Weight { get; set; }
        double DesiredOutput = 1.0;
        double LearningRate = 0.1;

        public void SetNeurons(double[] neurons)
        {
            Neuron = neurons;
        }

        public void SetWeights(double[] weights)
        {
            Weight = weights;
        }

        public double EvaluateNeuralNet(double[] neuron, double[] weight)
        {
            double result = 0;

            for(int i = 0; i < neuron.Length; i++)
            {
                double layerValue = neuron[i] * weight[i];

                result += layerValue;
            }

            return result;
        }

        public double EvaluateNeuralNetworkError(double desiredOutput, double output)
        {
            return (desiredOutput - output);
        }

        public void Learn(double[] neuron, double[] output)
        {
            for (int i = 0; i < neuron.Length; i++)
            {
                if (neuron[i] > 0) output[i] += LearningRate;
            }
        }

        public void Train(int trails)
        {
            for (int i = 0; i < trails; i++)
            {
                double neuralNetResult = EvaluateNeuralNet(Neuron, Weight);

                Console.WriteLine("Neural result: {0} Error: {1} Weight: {2}", neuralNetResult, EvaluateNeuralNetworkError(DesiredOutput, neuralNetResult), Weight);

                Learn(Neuron, Weight);

                Thread.Sleep(100);
            }
        }
    }
}
