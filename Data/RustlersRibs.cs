/*

* Author: John Boehm

* Class name: AngryChicken.cs

* Purpose: Implements the Rustlers Ribs entree

*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class RustlersRibs:Entree
    {
        /// <summary>
        /// price of the ribs
        /// </summary>
        public override double Price
        {
            get
            {
                return 7.50;
            }
        }
        /// <summary>
        /// calories for the ribs
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 894;
            }
        }
        /// <summary>
        /// any special instructions to add to the ribs
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();
                return instructions;
            }
        }
        /// <summary>
        /// converts object to a string
        /// </summary>
        /// <returns>the object as a string</returns>
        public override string ToString()
        {
            return "Rustler's Ribs";
        }
    }
}
