using Bytepushers.NeuralNet.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bytepushers.NeuralNet
{
    /// <summary>
    /// The nueral network
    /// </summary>
    public class Network : INetwork
    {
        /// <summary>
        /// Represents the collection of layers
        /// </summary>
        private IEnumerable<ILayer> _layers;

        /// <summary>
        /// Default class constructor
        /// </summary>
        public Network()
        {

        }

        /// <summary>
        /// Represents the collection of layers that make up the neural network
        /// </summary>
        public IEnumerable<ILayer> Layers
        {
            get
            {
                return _layers;
            }
        }
    }
}
