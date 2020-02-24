/*

* Author: John Boehm

* Class name: Water.cs

* Purpose:implements the water drink

*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class Water : Drink
    {

        public bool Lemon { get; set; } = false;
        /// <summary>
        /// gets the price of the water
        /// </summary>
        public override double Price{get { return 0.12; }}
        /// <summary>
        /// gets the calories of the water
        /// </summary>
        public override uint Calories { get { return 0; } }
        /// <summary>
        /// iff lemons or ice it adds them
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();
                if (Lemon) { instructions.Add("Add Lemon"); }
                if (!Ice) { instructions.Add("Hold Ice"); }
                return instructions;
            }
        }
        public override string ToString()
        {
            return Size.ToString() + " Water";
        }
    }
}
