using System;
using System.Collections.Generic;
using System.IO;
namespace GroceryOrder;

    public static class Files
    {
        public static void Create()
        {
            if(!Directory.Exists("GroceryOrder"))
            {
                Console.WriteLine("Creating Folder");
                Directory.CreateDirectory("Grocery Order");
            }
            if(!Directory.Exists("CustomerDetails"))
            {
                Console.WriteLine("Creating Customer File");
                Directory.CreateDirectory("GroceryOrder/CustomerDetails.csv");
            }
            if(!Directory.Exists("ProductDetails"))
            {
                Console.WriteLine("Creating Product File");
                Directory.CreateDirectory("GroceryOrder/ProductDetails.csv");
            }
            if(!Directory.Exists("BookingDetails"))
            {
                Console.WriteLine("Creating Customer File");
                Directory.CreateDirectory("GroceryOrder/BookingDetails.csv");
            }
            if(!Directory.Exists("OrderDetails"))
            {
                Console.WriteLine("Creating Customer File");
                Directory.CreateDirectory("GroceryOrder/OrderDetails.csv");
            }
        }

            public static void ReadFiles()
            {
                string[] customer=File.ReadAllLines("GroceryOrder/CustomerDetails.csv");
                string[] product=File.ReadAllLines("GroceryOrder/ProductDetails.csv");
                string[] booking=File.ReadAllLines("GroceryOrder/BookingDetails.csv");
                string[] order=File.ReadAllLines("GroceryOrder/OrderDetails.csv");

                Operations.customerList= CreateCustomerObjects(customer);
                Operations.productList=CreateProductObjects(product);
                Operations.bookingList=CreateBookingObjects(booking);
                Operations.orderList=CreateOrderObject(order);

            }
            public static List<CustomerDetails> CreateCustomerObjects(string[] customer)
            {
                List<CustomerDetails> customerList=new List<CustomerDetails>();
                foreach(string data in customer)
                {
                    string[] values=data.Split(",");
                    CustomerDetails.s_customerId=int.Parse(values[0].Remove(0,3));
                    string customerId=values[0];
                    string name=values[1];
                    string fatherName=values[2];
                    long mobile=long.Parse(values[3]);
                    
                    string gender=values[4];
                    DateTime dob=DateTime.ParseExact(values[5],"dd/MM/yyyy",null);
                    string mail=values[6];
                    CustomerDetails customers=new CustomerDetails(name,fatherName,mobile,gender,dob,mail);
                    customerList.Add(customers);
                }
                return customerList;
            }
            public static List<ProductDetails> CreateProductObjects(string[] product)
            {
                List<ProductDetails> productList=new List<ProductDetails>();
                foreach(string data in product)
                {
                    ProductDetails products=new ProductDetails(data);
                    productList.Add(products);
                }
                return productList;
            }

            public static  List<BookingDetails> CreateBookingObjects(string[] booking)
            {
                List<BookingDetails> bookingList=new List<BookingDetails>();
                foreach(string data in booking)
                {
                    BookingDetails bookings=new BookingDetails(data);
                    bookingList.Add(bookings);
                }
                return bookingList;

            }
            public  static  List<OrderDetails> CreateOrderObject(string[] order)
            {
                List<OrderDetails> orderList=new List<OrderDetails>();
                foreach(string data in order)
                {
                    OrderDetails orders=new OrderDetails(data);
                    orderList.Add(orders);
                }
                return orderList;

            }


            public static void WriteToFile()
            {
                string[] CustomerDetails=new string[Operations.customerList.Count];
                string[] ProductDetails=new string[Operations.productList.Count];
                string[] BookingDetails=new string[Operations.bookingList.Count];
                string[] OrderDetails=new string[Operations.orderList.Count];

                for(int i=0;i<Operations.customerList.Count;i++)
                {
                    CustomerDetails[i]=Operations.customerList[i].CustomerId+","+Operations.customerList[i].WalletBalance;
                }
                for(int i=0;i<Operations.productList.Count;i++)
                {
                    ProductDetails[i]=Operations.productList[i].ProductId+","+Operations.productList[i].ProductName+","+Operations.productList[i].QuantityAvailable+","+Operations.productList[i].PricePerQuantity;

                }
                for(int i=0;i<Operations.bookingList.Count;i++)
                {
                    BookingDetails[i]=Operations.bookingList[i].BookingId+","+Operations.bookingList[i].CustomerId+","+Operations.bookingList[i].TotalPrice+","+Operations.bookingList[i].Status;
                }


                
            }


            


            



    }
        
        
    
