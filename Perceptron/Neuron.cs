using System;
using System.Collections.Generic;
using System.Text;


namespace Perceptron
{
	public class Neuron
	{
		public double[] Weights { get; private set; }
		public double Bias { get; private set; }
		public double LearningRate { get; private set; }
		public Neuron(int numberOfInputs, double learningRate = 0.1)
		{
			LearningRate = learningRate;
			Random rand = new Random(1);
			Weights = new double[numberOfInputs];
			for (int i = 0; i < Weights.Length; i++)
			{
				Weights[i] = 2 * rand.NextDouble() - 1;
			}
			Bias = 2 * rand.NextDouble() - 1;
		}
		public double Activation(double x)
		{
			double sigmoid = 1 / (1 + Math.Exp(-x));
			return 2 * sigmoid - 1;
		}

		public double FeedForward(double[] inputs)
		{
			if (inputs.Length == Weights.Length)
			{
				double sum = 0;
				for (int i = 0; i < Weights.Length; i++)
				{
					sum += Weights[i] * inputs[i];
				}
				sum += Bias;
				return Activation(sum);
			}
			else
			{
				throw new ArgumentException("Input array must be same length as weight array");
			}
			
		}
		public void Train(double[] inputs,double expectedOutput)
		{
			if (inputs.Length == Weights.Length)
			{
				double calculatedOutput = FeedForward(inputs);
				double error = expectedOutput - calculatedOutput;
				Console.WriteLine(error);
				for (int i = 0; i < Weights.Length; i++)
				{
					Weights[i] += LearningRate * error * inputs[i];
				}
				Bias += LearningRate * error;
			}
			else
			{
				throw new ArgumentException("Input array must be same length as weight array");
			}
		}
	}
}
