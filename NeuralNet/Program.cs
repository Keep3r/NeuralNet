using System;

namespace NeuralNet
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] neurons = { 0, 0, 1, 0};
            double[] weights = { 0, 0, 0, 0};

            Console.Write("Times to trains the neural network: ");
            int timesToTrain = Convert.ToInt32(Console.ReadLine());

            Neurons neuron = new Neurons();

            neuron.SetNeurons(neurons);
            neuron.SetWeights(weights);

            neuron.Train(timesToTrain);

            Console.ReadLine();
        }
    }
}
