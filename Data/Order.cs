/*
 * Author:John Boehm
 * Order.cs
 * Purpose: Impplements an order for the cowboy cafe
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
namespace CowboyCafe.Data
{
    public class Order:INotifyPropertyChanged
    {
        private static uint lastOrderNumber = 1;

        /// <summary>
        /// property changed modifier
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        private double subtotal = 0;
        /// <summary>
        /// gives the price for the item
        /// </summary>
        public double Subtotal { get { return subtotal; } }
        private List<IOrderItem> items = new List<IOrderItem>();
        /// <summary>
        /// the items of the ienumerable gives the items in the order
        /// </summary>
        public IEnumerable<IOrderItem> Items 
        {
            get { return items; }
        }
        /// <summary>
        /// adds an item to the order
        /// </summary>
        /// <param name="item"></param>
        public void Add(IOrderItem item) 
        {
            items.Add(item);
            item.PropertyChanged += OnItemChanged;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            subtotal += item.Price;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
        }
        /// <summary>
        /// removes the item from the order
        /// </summary>
        /// <param name="item"></param>
        public void Remove(IOrderItem item) 
        {
            items.Remove(item);
            item.PropertyChanged -= OnItemChanged;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            subtotal -= item.Price;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));

        }
        /// <summary>
        /// gives the order number
        /// </summary>
        public uint OrderNumber
        {
            get
            {
                lastOrderNumber++;
                return lastOrderNumber;
            }
        }
        private void OnItemChanged(object sender,PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            if (e.PropertyName == "Price") { PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal")); }
        }

    }
}
