/*

* Author: John Boehm

* Class name: DakotaDoubleBurger.cs

* Purpose: Implements the dakota double burger entree

*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class DakotaDoubleBurger:Entree
    {
        /// <summary>
        /// if the burger has pickle
        /// </summary>
        public bool Pickle { get; set; } = true;
        /// <summary>
        /// if the burger has a bun
        /// </summary>
        public bool Bun { get; set; } = true;
        /// <summary>
        /// if the burger has tomato
        /// </summary>
        public bool Tomato { get; set; } = true;
        /// <summary>
        /// if the burger has lettuce
        /// </summary>
        public bool Lettuce { get; set; } = true;
        /// <summary>
        /// if the burger has mayo
        /// </summary>
        public bool Mayo { get; set; } = true;
        /// <summary>
        /// if the burger has ketchup
        /// </summary>
        public bool Ketchup { get; set; } = true;
        /// <summary>
        /// if the burger has mustard
        /// </summary>
        public bool Mustard { get; set; } = true;
        /// <summary>
        /// if the burger has cheese
        /// </summary>
        public bool Cheese { get; set; } = true;
        /// <summary>
        /// price of the dakota double burger
        /// </summary>
        public override double Price
        {
            get { return 5.20; }
        }
        /// <summary>
        /// Calories of the dakota double burger
        /// </summary>
        public override uint Calories
        {
            get { return 464; }
        }
        /// <summary>
        /// Special Instructions for the dakota double burger 
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!Bun) instructions.Add("hold bun");
                if (!Pickle) instructions.Add("hold pickle");
                if (!Tomato) instructions.Add("hold tomato");
                if (!Lettuce) instructions.Add("hold lettuce");
                if (!Mayo) instructions.Add("hold mayo");
                if (!Ketchup) instructions.Add("hold ketchup");
                if (!Mustard) instructions.Add("hold mustard");
                if (!Cheese) instructions.Add("hold cheese");

                return instructions;
            }
        }
        /// <summary>
        /// converts object to a string
        /// </summary>
        /// <returns>the object as a string</returns>
        public override string ToString()
        {
            return "Dakota Double Burger";
        }
    }
}
