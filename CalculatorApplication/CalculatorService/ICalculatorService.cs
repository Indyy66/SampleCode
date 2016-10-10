using Microsoft.ServiceFabric.Services.Remoting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorService
{
    /// <summary>
    /// Calculator interface class
    /// </summary>
    /// <seealso cref="Microsoft.ServiceFabric.Services.Remoting.IService" />
    public interface ICalculatorService : IService
    {
        /// <summary>
        /// Adds the specified a.
        /// </summary>
        /// <param name="a">a.</param>
        /// <param name="b">The b.</param>
        /// <returns></returns>
        Task<int> Add(int a, int b);

        /// <summary>
        /// Subtracts the specified a.
        /// </summary>
        /// <param name="a">a.</param>
        /// <param name="b">The b.</param>
        /// <returns></returns>
        Task<int> Subtract(int a, int b);
    }
}
