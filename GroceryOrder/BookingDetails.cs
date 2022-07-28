using System;
namespace GroceryOrder
{
    public enum Status{Default,Initiate,Booked,Cancelled}
    public class BookingDetails
    {
        private int s_bookingId=200;
        public string BookingId{get;}
        public string CustomerId{get;set;}
        public double TotalPrice{get;set;}
        public Status Status{get;set;}

        public BookingDetails(string customerId,double totalPrice,Status status)
        {
            s_bookingId++;
            BookingId="BID"+s_bookingId;
            CustomerId=customerId;
            TotalPrice=totalPrice;
            Status=status;

        }
        public BookingDetails(string data)
        {
            string[] values=data.Split(",");
            s_bookingId=int.Parse(values[0].Remove(0,3));
            BookingId=values[0];
            CustomerId=values[1];
            TotalPrice=double.Parse(values[2]);
            Status=Enum.Parse<Status>(values[3]);

        }
        
    }
}