using System.Collections;
using System.Collections.Generic;
namespace Bytepushers.NeuralNet.Interfaces
{
    /// <summary>
    /// Represents a layer of neurons
    /// </summary>
    public interface ILayer
    {
        /// <summary>
        /// The collection of neurons
        /// </summary>
        IEnumerable<Neuron> Neurons { get; }

        /// <summary>
        /// The type of layer we are dealing with
        /// </summary>
        LayerTypes LayerType { get; set; }
    }
}