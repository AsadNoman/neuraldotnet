using System;

namespace NeuralDotNet
{
	public class Neuron
	{
        
    public static Random randomR = new Random();
		int numInputs;
		double[] weights;
		public Neuron(int initNumInputs)
		{
			numInputs = initNumInputs + 1; 
			weights = new double[numInputs];

            for (int i = 0; i < numInputs; i++)
                weights[i] = ((float)(randomR.NextDouble()) * 2) - 1;   
		}

		public double NumInputs
		{
            get
            {
                return numInputs;
            }
		}

		public void SetWeight(int index, double newVal)
		{
			weights[index] = newVal;
		}

		public double GetWeight(int index)
		{
			return weights[index];
		}
	
	}
}
