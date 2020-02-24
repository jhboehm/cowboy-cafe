/*

* Author: John Boehm

* Class name: PecosPulledPork.cs

* Purpose: Implements the pecos pulled pork entree

*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class PecosPulledPork:Entree
    {
        private bool bread = true;
        /// <summary>
        /// If the pulled pork is served with bread
        /// </summary>
        public bool Bread
        {
            get { return bread; }
            set { bread = value; }
        }
        /// <summary>
        /// If the angry chicken is served with pickle
        /// </summary>
        public bool Pickle { get; set; } = true;
        /// <summary>
        /// price of the pecos pulled pork
        /// </summary>
        public override double Price
        {
            get { return 5.88; }
        }
        /// <summary>
        /// Calories of the pecos pulled pork
        /// </summary>
        public override uint Calories
        {
            get { return 528; }
        }
        /// <summary>
        /// Special Instructions for the pecos pulled pork 
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!bread) instructions.Add("hold bread");
                if (!Pickle) instructions.Add("hold pickle");

                return instructions;
            }
        }
        public override string ToString()
        {
            return "Pecos Pulled Pork";
        }
    }
}
