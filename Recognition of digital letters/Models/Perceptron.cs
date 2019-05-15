using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecognitionOfDigitalLetters.Models
{
    public class Perceptron
    {
        float[] Weights { get; set; }
        float[] Inputs { get; set; }

        float Bias { get; set; }
        float BiasWeight { get; set; }

        public Perceptron(int n)
        {
            Weights = new float[n];
            Inputs = new float[n];
            Random rnd = new Random();

            for (int i = 0; i < Weights.Length; i++)
            {
                Weights[i] = rnd.Next(-1, 1);
            }
            BiasWeight = rnd.Next(-1, 1);
        }

        public int Feedforward()
        {
            float sum = 0;
            for (int i = 0; i < Weights.Length; i++)
            {
                sum += Inputs[i] * Weights[i];
            }
            sum += Bias * BiasWeight;

            return Activate(sum);
        }

        private int Activate(float sum)
        {
            if (sum < 0)
            {
                return -1;
            }
            else if (sum >= 0)
            {
                return 1;
            }
            else
            {
                return 1;
            }
        }
    }
}
