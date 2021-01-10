using System;
using System.IO;
using System.Collections.Generic;

namespace Perceptron
{
	class Program
	{
		static void Main()
		{
			List<Point> points = GetPointsFromCSV();
			Neuron perceptron = new Neuron(2);
			for (int i = 0; i < 5; i++)
			{
				foreach (Point point in points)
				{
					double[] inputs = new double[] { point.X, point.Y };
					double expectedOutput = point.Label;
					perceptron.Train(inputs, expectedOutput);
				}
			}
		}

		public static List<Point> GetPointsFromCSV()
		{
			StreamReader reader = new StreamReader(File.OpenRead(@"C:\Users\rober\OneDrive\Documents\CodingProjects\Perceptron\PerceptronTrainingData.csv"));
			List<Point> pointsList = new List<Point>();
			while (!reader.EndOfStream)
			{
				string line = reader.ReadLine();
				Point point = new Point();
				string[] values = line.Split(',');
				point.X = double.Parse(values[0]);
				point.Y = double.Parse(values[1]);
				point.Label = int.Parse(values[2]);
				pointsList.Add(point);
			}
			return pointsList;
		}
	}

}
