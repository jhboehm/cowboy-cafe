﻿using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using CowboyCafe.Data;
namespace CowboyCafe.DataTests
{
    public class OrderTests
    {
        public class MockOrderItem : IOrderItem
        {
            public double Price { get; set; }
            public List<string> SpecialInstructions { get; set; }
        }
        [Fact]
        public void ShouldBeAbleToAddItems()
        {
            var order = new Order();
            var item = new MockOrderItem();
            order.Add(item);
            Assert.Contains(item, order.Items);
        }
        [Fact]
        public void ShouldBeAbleToRemoveItems()
        {
            var order = new Order();
            var item = new MockOrderItem();
            order.Add(item);
            order.Remove(item);
            Assert.DoesNotContain(item, order.Items);
        }
        [Fact]
        public void ShouldBeAbleToGetAnEnumerationOfItems()
        {
            var order = new Order();
            var item0 = new MockOrderItem();
            var item1 = new MockOrderItem();
            var item2 = new MockOrderItem();
            order.Add(item0);
            order.Add(item1);
            order.Add(item2);

            Assert.Collection(order.Items,
                item => Assert.Equal(item0, item),
                item => Assert.Equal(item1, item),
                item => Assert.Equal(item2, item));
        }
        [Theory]
        [InlineData(new double[] { 1,2,3})]
        [InlineData(new double[] { 0, 0, 0 })]
        [InlineData(new double[] { 1.99, 7.99 })]
        [InlineData(new double[] { 7.98 })]
        [InlineData(new double[] { })]
        [InlineData(new double[] { -5 })]
        [InlineData(new double[] {-4,10,8 })]
        [InlineData(new double[] { 3.19238797394696 })]
        [InlineData(new double[] { double.NaN })]
        public void ShouldBeTheSumOfItemPrices(double[] prices)
        {
            var order = new Order();
            var total = 0.0;
            foreach(var price in prices)
            {
                total += price;
                order.Add(new MockOrderItem()
                {
                    Price = price
                });

            }
            Assert.Equal(total, order.Subtotal);
        }
        [Theory]
        [InlineData( "Price" )]
        [InlineData("Items" )]
        public void AddingAnItemShouldTriggerPropertyChanged(string propertyName)
        {
            var order = new Order();
            var item = new MockOrderItem();
            Assert.PropertyChanged(order, propertyName, () => {
                order.Add(item);
            });
            
        }

        [Theory]
        [InlineData("Price")]
        [InlineData("Items")]
        public void RemovingAnItemShouldTriggerPropertyChanged(string propertyName)
        {
            var order = new Order();
            var item = new MockOrderItem();
            order.Add(item);
            Assert.PropertyChanged(order, propertyName, () => {
                order.Remove(item);
            });

        }
        [Fact]
        public void TwoOrderNumbersShouldNotBeTheSame()
        {
            var order = new Order();
            var order1 = new Order();
            Assert.NotEqual(order.OrderNumber, order1.OrderNumber);
        }

    }
}
