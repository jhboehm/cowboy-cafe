/*

* Author: John Boehm

* Class name: CowboyCoffee.cs

* Purpose:implements the Cowboy coffee drink

*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class CowboyCoffee : Drink
    {
        public bool Ice { get; set; } = false;
        public bool RoomForCream { get; set; } = false;
        public bool Decaf { get; set; } = false;
        /// <summary>
        /// gets the price of  the coffee depending on size
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 1.60;
                    case Size.Medium:
                        return 1.10;
                    case Size.Small:
                        return 0.60;
                    default:
                        throw new NotImplementedException("Unknown Size");
                }
            }
        }

        /// <summary>
        /// gets the calories of the coffee depending on size
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 7;
                    case Size.Medium:
                        return 5;
                    case Size.Small:
                        return 3;
                    default:
                        throw new NotImplementedException("Unknown Size");
                }
            }
        }
        /// <summary>
        /// gets any special instructions for the coffee
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();
                if (RoomForCream) { instructions.Add("Room for Cream"); }
                if (Ice) { instructions.Add("Add Ice"); }
                return instructions;
            }
        }
    }
}
