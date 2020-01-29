using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class PecosPulledPork
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
        public double Price
        {
            get { return 5.88; }
        }
        /// <summary>
        /// Calories of the pecos pulled pork
        /// </summary>
        public uint Calories
        {
            get { return 528; }
        }
        /// <summary>
        /// Special Instructions for the pecos pulled pork 
        /// </summary>
        public List<string> SpecialInstructions
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
