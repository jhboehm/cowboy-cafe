/*

* Author: John Boehm

* Class name: AngryChicken.cs

* Purpose: Implements the angry chicken entree

*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class AngryChicken: Entree
    {
        private bool bread = true;
        /// <summary>
        /// If the angry chicken is served with bread
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
        /// price of the angry chicken
        /// </summary>
        public override double Price
        {
            get { return 5.99; }
        }
        /// <summary>
        /// Calories of the angry chicken
        /// </summary>
        public override uint Calories
        {
            get { return 190; }
        }
        /// <summary>
        /// Special Instructions for the angry chicken 
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



    }
}
