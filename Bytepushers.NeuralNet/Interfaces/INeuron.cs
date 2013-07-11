using System;
using System.Collections.Generic;
namespace Bytepushers.NeuralNet
{
    public interface INeuron
    {
        Func<IEnumerable<double>, double> Activator { get; set; }
        double Bias { get; set; }
        IEnumerable<double> Weights { get; set; }
    }
}
