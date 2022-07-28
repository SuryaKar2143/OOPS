using System;
using System.Collections.Generic;
namespace Ecommerce
{
    public enum OrderStatus{Default,Ordered,Cancelled}
    public class OrderDetail
    {
        private static int s_orderId=1000;
        public string OrderId{get;}

        public string CustomerId{get;set;}
        public string ProductId{get;set;}
        public double TotalPrice{get;set;}
        public DateTime PurchaseDate{get;set;}
        public int Quality{get;set;}
        public OrderStatus OrderStatus{get;set;}
       
       public  OrderDetail(String customerId,String productId,double totalPrice, DateTime purchaseDate,int quality,OrderStatus orderStatus)
       {
        s_orderId++;
        OrderId="OID"+s_orderId;
        CustomerId=customerId;
        ProductId=productId;
        TotalPrice=totalPrice;
        PurchaseDate=purchaseDate;
        Quality=quality;
        OrderStatus=orderStatus;

       }
       





        
    }
}