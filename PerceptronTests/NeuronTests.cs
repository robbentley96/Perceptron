using System;
using NUnit.Framework;
using Perceptron;

namespace PerceptronTests
{
	public class NeuronTests
	{
		[SetUp]
		public void Setup()
		{
		}

		[Test]
		public void WhenNeuronIsCreated_ItHasTheNumberOfWeightsAssignedInTheConstructorArguments()
		{
			var testNeuron = new Neuron(7);
			Assert.That(testNeuron.Weights.Length, Is.EqualTo(7));
		}

		[Test]
		public void WhenNeuronIsTrainedWithWrongNumberOfInputs_ArgumentExceptionErrorIsThrown()
		{
			var testNeuron = new Neuron(7);
			var testInputs = new double[] { 0.1, -0.3, 0.4, -0.8, 0.6 };
			Assert.Throws<ArgumentException>(() => testNeuron.Train(testInputs,1));
		}

		[Test]
		public void WhenFeedForwardMethodWithWrongNumberOfInputsIsCalled_ArgumentExceptionErrorIsThrown()
		{
			var testNeuron = new Neuron(7);
			var testInputs = new double[] { 0.1, -0.3, 0.4, -0.8, 0.6 };
			Assert.Throws<ArgumentException>(() => testNeuron.FeedForward(testInputs));
		}
	}
}