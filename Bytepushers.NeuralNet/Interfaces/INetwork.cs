using System.Collections;
using System.Collections.Generic;
namespace Bytepushers.NeuralNet.Interfaces
{
    /// <summary>
    /// Represents a neural network
    /// </summary>
    public interface INetwork
    {
        /// <summary>
        /// Represents the collection of layers in the network
        /// </summary>
        IEnumerable<ILayer> Layers { get; }
    }
}