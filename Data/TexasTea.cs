/*

* Author: John Boehm

* Class name: TexasTea.cs

* Purpose:implements the Texas tea drink

*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class TexasTea : Drink
    {
        public bool Sweet { get; set; } = true;
        public bool Lemon { get; set; } = false;
        /// <summary>
        /// gets the price for the texas tea depending on size
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 2.00;
                    case Size.Medium:
                        return 1.50;
                    case Size.Small:
                        return 1.00;
                    default:
                        throw new NotImplementedException("Unknown Size");
                }
            }
        }
        /// <summary>
        /// gets the calories for the texas tea depending on size and sweetener
        /// </summary>
        public override uint Calories
        {
            get
            {
                uint cal;
                switch (Size)
                {
                    case Size.Large:
                        cal = 36;
                        break;
                    case Size.Medium:
                        cal=  22;
                        break;
                    case Size.Small:
                        cal = 10;
                        break;
                    default:
                        throw new NotImplementedException("Unknown Size");
                }
                if (!Sweet) { cal /= 2; }
                return cal;
                
            }
        }
        /// <summary>
        /// if any special instructions it will add them to a list 
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
            if (Sweet) { return Size.ToString() + " Texas Sweet Tea"; }
            return Size.ToString() + " Texas Plain Tea";
        }
    }
}
