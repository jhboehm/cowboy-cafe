/*

* Author: John Boehm

* Class name: Drink.cs

* Purpose: Abstract base class for the rest of the drinks

*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public abstract class Drink
    {
        /// <summary>
        /// holds the size of the drinks
        /// </summary>
        public Size Size { get; set; } = Size.Small;
        /// <summary>
        /// the price of the drinks
        /// </summary>
        public abstract double Price { get; }
        /// <summary>
        /// the calories of the drinks
        /// </summary>
        public abstract uint Calories { get;}
        /// <summary>
        /// true if the user wants ice
        /// </summary>
        public bool Ice { get; set; } = true;
        /// <summary>
        /// holds andy special instructions for the drink
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
    }
}
