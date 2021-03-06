﻿/*

* Author: John Boehm

* Class name: TrailBurger.cs

* Purpose: Implements the trail burger entree

*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class TrailBurger:Entree
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
        /// price of the trail burger
        /// </summary>
        public override double Price
        {
            get { return 4.50; }
        }
        /// <summary>
        /// Calories of the trail burger
        /// </summary>
        public override uint Calories
        {
            get { return 288; }
        }
        /// <summary>
        /// Special Instructions for the trail burger 
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!Bun) instructions.Add("hold bun");
                if (!Pickle) instructions.Add("hold pickle");
                if (!Ketchup) instructions.Add("hold ketchup");
                if (!Mustard) instructions.Add("hold mustard");
                if (!Cheese) instructions.Add("hold cheese");

                return instructions;
            }
        }
        public override string ToString()
        {
            return "Trail Burger";
        }
    }
}
