using System;
namespace GroceryOrder
{
    public class OrderDetails
    {
        private int s_orderId=400;
        public string OrderId{get;set;}
        public string BookingId{get;set;}
        public string ProductId{get;set;}
        public int PurchaseCount{get;set;}
        public double PriceOfOrder{get;set;}
        


        public OrderDetails(string bookingId,string productId,int purchaseCount,double priceOfOrder)
        {
            s_orderId++;
            OrderId="OID"+s_orderId;
            BookingId=bookingId;
            ProductId=productId;
            PurchaseCount=purchaseCount;
            PriceOfOrder=priceOfOrder;
        }

        public OrderDetails(string data)
        {
            string [] values=data.Split(",");
            s_orderId=int.Parse(values[0].Remove(0,3));
            OrderId=values[0];
            BookingId=values[1];
            ProductId=values[2];
            PurchaseCount=int.Parse(values[3]);
            PriceOfOrder=double.Parse(values[4]);

        }
        
    }
}