using System;
using System.Collections.Generic;
namespace Ecommerce
{
    public class ProdectDetail
    {
        private static int s_productId=100;
        public string ProductId{get;}
        public string ProductName{get;set;}
        public int  Stock{get;set;}
        public double Price{get;set;}
        public int Days{get;set;}


        public ProdectDetail(string Name,int  stock,double price,int days)
        {
            s_productId++;
            ProductId="PID"+s_productId;
            ProductName=Name;
            Stock=stock;
            Price=price;
            Days=days;
        }
        

    }
}