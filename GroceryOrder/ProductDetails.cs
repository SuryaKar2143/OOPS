using System;
namespace GroceryOrder
{
    public class ProductDetails
    {
        public string ProductId{get;set;}
        public string ProductName{get;set;}
        public int QuantityAvailable{get;set;}
        public double PricePerQuantity{get;set;}

        public ProductDetails(string productId,string productName,int quantityAvailable,double pricePerQuantity)
        {
            ProductId=productId;
            ProductName=productName;
            QuantityAvailable=quantityAvailable;
            PricePerQuantity=pricePerQuantity;
        }


        public ProductDetails(string data)
        {
            string[] values=data.Split(",");
            ProductId=values[0];
            ProductName=values[1];
            QuantityAvailable=int.Parse(values[2]);
            PricePerQuantity=double.Parse(values[3]);

        }
    }
}