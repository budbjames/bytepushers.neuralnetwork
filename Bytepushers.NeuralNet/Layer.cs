using Bytepushers.NeuralNet.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bytepushers.NeuralNet
{
    /// <summary>
    /// Represents the types of layers that the network can have.
    /// </summary>
    public enum LayerTypes
    {
        InputLayer = 0,
        HiddenLayer = 1,
        OutputLayer = 2,
    }

    /// <summary>
    /// Represents a layer in the neural network
    /// </summary>
    public class Layer : ILayer
    {
        /// <summary>
        /// Represents the collection of neurons that make up the layer
        /// </summary>
        private IEnumerable<Neuron> _neurons;

        /// <summary>
        /// Represents the type of layer
        /// </summary>
        private LayerTypes _layerType;

        /// <summary>
        /// Default class constructor
        /// </summary>
        public Layer()
        {
            _neurons = new List<Neuron>();
        }
        
        /// <summary>
        /// Represents the collection of neurons that make up the layer
        /// </summary>
        public IEnumerable<Neuron> Neurons
        {
            get
            {
                return _neurons;
            }
        }

        /// <summary>
        /// Represents the type of layer
        /// </summary>
        public LayerTypes LayerType
        {
            get
            {
                return _layerType;
            }
            set
            {
                _layerType = value;
            }
        }
    }
}
