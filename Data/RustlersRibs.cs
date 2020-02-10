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
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();
                return instructions;
            }
        }
    }
}
