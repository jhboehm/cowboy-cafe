/*

* Author: John Boehm

* Class name: Entree.cs

* Purpose: Implements the entree base class

*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public abstract class Entree:IOrderItem
    {
        /// <summary>
        /// Gets the price of the entree
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// Gets the calories of the entree
        /// </summary>
        public abstract uint Calories { get; }
        /// <summary>
        /// Gets any special instructions
        /// </summary>
        public virtual List<string> SpecialInstructions { get; }
    }
}
