/*

* Author: John Boehm

* Class name: TexasTripleBurger.cs

* Purpose: Implements the texas triple burger entree

*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class TexasTripleBurger:Entree
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
        /// If the burger has Bacon
        /// </summary>
        public bool Bacon { get; set; } = true;
        /// <summary>
        /// if the burger has egg
        /// </summary>
        public bool Egg { get; set; } = true;
        /// <summary>
        /// price of the texas triple burger
        /// </summary>
        public override double Price
        {
            get { return 6.45; }
        }
        /// <summary>
        /// Calories of the texas triple burger
        /// </summary>
        public override uint Calories
        {
            get { return 698; }
        }
        /// <summary>
        /// Special Instructions for the texas triple burger 
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
                if (!Egg) instructions.Add("hold egg");
                if (!Bacon) instructions.Add("hold bacon");

                return instructions;
            }
        }
        public override string ToString()
        {
            return "Texas Triple Burger";
        }
    }
}
