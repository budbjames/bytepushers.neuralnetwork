using Bytepushers.NeuralNet.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bytepushers.NeuralNet
{
    /// <summary>
    /// Represents a neuron or node in a neural network
    /// </summary>
    public class Neuron : INeuron
    {
        /// <summary>
        /// Represents the weight values of the specified Neuron
        /// </summary>
        public IEnumerable<double> Weights { get; set; }

        /// <summary>
        /// Represents the bias of the neuron
        /// </summary>
        public double Bias { get; set; }

        /// <summary>
        /// Represents an activator function
        /// </summary>
        public Func<IEnumerable<double>, double> Activator { get; set; }

        /// <summary>
        /// Default class constructor
        /// </summary>
        /// <param name="activator">The activator function</param>
        public Neuron(Activator activator)
        {
            if (activator == null)
                throw new ArgumentNullException("activator");
        }
    }
}
