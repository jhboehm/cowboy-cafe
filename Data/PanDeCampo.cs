/*

* Author: John Boehm

* Class name: PanDeCampo.cs

* Purpose: Implements the pan de camp side 

*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class PanDeCampo : Side
    {
        /// <summary>
        /// gets the price of the pan de campo
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 1.99;
                    case Size.Medium:
                        return 1.79;
                    case Size.Small:
                        return 1.59;
                    default:
                        throw new NotImplementedException("Unknown Size");
                }

            }
        }
        /// <summary>
        /// gets the price of the pan de campo side
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 367;
                    case Size.Medium:
                        return 269;
                    case Size.Small:
                        return 227;
                    default:
                        throw new NotImplementedException("Unknown Size");
                }

            }
        }
        public override string ToString()
        {
            return Size.ToString() + " Pan de Campo";
        }
    }
}
