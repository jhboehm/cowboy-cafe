/*

* Author: John Boehm

* Class name: BakedBeans.cs

* Purpose: Implements the baked bean side

*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class BakedBeans : Side
    {
        /// <summary>
        /// gets the price of the baked beans
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
        /// gets the calories of baked beans
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 410;
                    case Size.Medium:
                        return 378;
                    case Size.Small:
                        return 312;
                    default:
                        throw new NotImplementedException("Unknown Size");
                }

            }
        }
        /// <summary>
        /// converts object to a string
        /// </summary>
        /// <returns>the object as a string</returns>
        public override string ToString()
        {
            return Size.ToString() + " Baked Beans";
        }
    }
}
