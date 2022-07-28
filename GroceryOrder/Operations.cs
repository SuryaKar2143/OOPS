using System;
using System.Collections.Generic;
namespace GroceryOrder
{
    public class Operations
    {
        public static List<PersonalInfo> personalList=new List<PersonalInfo>();
        public static List<CustomerDetails> customerList=new List<CustomerDetails>();
        public static List<ProductDetails> productList=new List<ProductDetails>();
        public static List<BookingDetails> bookingList=new List<BookingDetails>();
        public static List<OrderDetails> orderList=new List<OrderDetails>();
        public static CustomerDetails currentUser=null;
        
        public static void MainMenu()
        {
            Console.WriteLine("Main Menu");
            Console.WriteLine("Choose your Choice:\n1.Registration\n2.Login\n3.Exit");
            int choice=int.Parse(Console.ReadLine());
            switch(choice)
            {
                case 1:
                {
                    Console.WriteLine("Registration Page");
                    Registration();
                    break;
                }
                case 2:
                {
                    Console.WriteLine("Login Page");
                    Login();
                    break;
                }
                case 3:
                {
                    Console.WriteLine("Exit Main Menu");
                    break;
                }

            }
            
            static void Registration()
            {
                Console.WriteLine("Enter the  Name of the Person        :");
                string name=Console.ReadLine();
                Console.WriteLine("Enter the father's Name              :");
                string fatherName=Console.ReadLine();
                Console.WriteLine("Enter the Mobile Number              :");
                long mobile=long.Parse(Console.ReadLine());
                Console.WriteLine("Enter Gender of the Person           :");
                string gender=Console.ReadLine();
                Console.WriteLine("Enter the Date of Birth              :");
                DateTime dob=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
                Console.WriteLine("Enter the Mail Id                    :");
                string mail=Console.ReadLine();
                

                //PersonalInfo person1=new PersonalInfo(name,fatherName,mobile,gender,dob,mail);
                //personalList.Add(person1);
                CustomerDetails customer=new CustomerDetails(name,fatherName,mobile,gender,dob,mail);
                customerList.Add(customer);

                Console.WriteLine("Your Id Is :{0}",customer.CustomerId);
                Login();



            }
            static void Login()
            {
                Console.WriteLine("Enter the Login Id For Check(CID1001-CID1100)    :");
                string id=Console.ReadLine();
                foreach(CustomerDetails customer in customerList)
                {
                    if(id==customer.CustomerId)
                    {
                        currentUser=customer;
                        SubMainMenu();
                    }
                }


            }

        }
        public static void SubMainMenu()
        {
            string option="yes";
            do{
                Console.WriteLine("Sub Main Menu");
                Console.WriteLine("Choose your Option\n1.Show  Customer Details\n2.Show Product Details \n3.Take Order \n4.Modify Order Quantity \n5.Cancel Order \n6.Exit");
                int choice=int.Parse(Console.ReadLine());
               
                switch(choice)
                {
                    case 1:
                    {
                        Console.WriteLine("Show  Customer Details");
                        ShowCustomerDetails();
                        break;
                    }
                    case 2:
                    {
                        Console.WriteLine("Show Product Details");
                        ShowProductDetails();
                        break;
                    }
                    case 3:
                    {
                        Console.WriteLine("Take Order");
                        TakeOrder();
                        break;
                    }
                    case 4:
                    {
                        Console.WriteLine("Modify Order Quantity");
                        ModifyOrderQuantity();
                        break;
                    }
                    case 5:
                    {
                        Console.WriteLine("Cancel Order");
                        CancelOrder();
                        break;
                    }
                    case 6:
                    {
                        Console.WriteLine("Exit");
                        option="no";
                        break;
                    }
                }

              }while(option=="yes");

              static void ShowCustomerDetails()
              {
                foreach(CustomerDetails customer in customerList)
                {
                    Console.WriteLine("Customer Name            :       {0}",customer.Name);
                    Console.WriteLine("Customer Id              :       {0}",customer.CustomerId);
                    Console.WriteLine("Initally Wallet Balance  :       {0}",customer.WalletBalance);
                }

              }
              static void ShowProductDetails()
              {
                foreach(ProductDetails product in productList)
                {
                    Console.WriteLine("Product Id           :       {0}",product.ProductId);
                    Console.WriteLine("Product Name         :       {0}",product.ProductName);
                    Console.WriteLine("Product Quantity     :       {0}",product.QuantityAvailable);
                    Console.WriteLine("Product Price is     :       {0}",product.PricePerQuantity);
                }
                
              }
             static void TakeOrder()
              {
                string choice="";
                do
                {
                    Console.WriteLine("Do you want to Purchase(yes/no) :");
                    choice=Console.ReadLine();
                    if(choice=="yes")
                    {
                        BookingDetails booking1=new BookingDetails(CustomerId,totalPrice,Status.Default);
                        booking1.CustomerId=currentUser.CustomerId;
                        bookingList.Add(booking1);
                        Console.WriteLine("Available Product Details");
                        ShowProductDetails();
                        Console.WriteLine("Enter the Product Id : ");
                        string id=Console.ReadLine().ToUpper();
                        Console.WriteLine("Enter the Quantity : ");
                        int quantity=int.Parse(Console.ReadLine());

                        foreach(ProductDetails product in productList)
                        {
                            if(product.ProductId==id && product.QuantityAvailable>=quantity)
                            {
                                double totalPrice=quantity*product.PricePerQuantity;
                                product.QuantityAvailable=quantity;
                                OrderDetails order1=new OrderDetails(booking1.BookingId,product.ProductId,quantity,totalPrice);
                                booking1.Status=Status.Booked;
                                Console.WriteLine("Order Successful. Your id is {0}",order1.OrderId);
                                orderList.Add(order1);    
                            }

                        }
                    }

                }while(choice=="yes");
                    
                    
              }

            

              
              static void ModifyOrderQuantity()
              {
                Console.WriteLine("Your Order Detail:");
                foreach(BookingDetails booking in bookingList)
                {
                    if(booking.CustomerId==currentUser.CustomerId)
                    {
                        Console.WriteLine("Booking Id   :   {0}",booking.BookingId);
                        Console.WriteLine("customer Id   :   {0}",currentUser.CustomerId);
                        Console.WriteLine("Total Price   :   {0}",booking.TotalPrice);
                        Console.WriteLine("Booking Status   :   {0}",booking.Status);
                    }

                }
                Console.WriteLine("which one do you want to Modify:\n Enter the Booking Id:");
                string id1=Console.ReadLine();
                int key=0;
                foreach(BookingDetails booking in bookingList)
                {
                    if(booking.BookingId==id1&& booking.Status==Status.Booked)
                    {
                        key=1;
                    }
                }
                if(key==1)
                {
                  foreach(OrderDetails order in orderList)
                  {
                    if(order.BookingId==id1)
                    {
                        Console.WriteLine("Order Id :   {0}",order.OrderId);
                        Console.WriteLine("Booking  Id :   {0}",order.BookingId);
                        Console.WriteLine("product Id :   {0}",order.ProductId);
                        Console.WriteLine("Purchase count :   {0}",order.PurchaseCount);
                        Console.WriteLine("Order Id :   {0}",order.OrderId);
                        Console.WriteLine("Price of order :   {0}",order.PriceOfOrder);
                    }
                  }
                  Console.WriteLine("pick one order id to modify : ");
                  string id2=Console.ReadLine().ToUpper();
                  foreach(OrderDetails order in orderList)
                  {
                    if(order.OrderId==id2)
                    {
                        Console.WriteLine("Enter the number of Quantity of Product :");
                        int quantity=int.Parse(Console.ReadLine());
                        order.PurchaseCount+=quantity;
                        double price=((order.PriceOfOrder/order.PurchaseCount)*quantity);
                        order.PriceOfOrder+=price;
                        foreach(BookingDetails booking in bookingList)
                        {
                            if(booking.CustomerId==currentUser.CustomerId)
                            {
                                booking.TotalPrice+=price;
                            }
                        }
                    }
                  }

                }



              }
              static void CancelOrder()
              {
                int key=0;
                foreach(BookingDetails booking in bookingList)
                {
                    if(booking.CustomerId==currentUser.CustomerId&&booking.Status==Status.Booked)
                    {
                        Console.WriteLine("Booking Id   :   {0}",booking.BookingId);
                        Console.WriteLine("Customer Id   :   {0}",booking.CustomerId);
                        Console.WriteLine("Total Price   :   {0}",booking.TotalPrice);
                        Console.WriteLine("Booking Status   :   {0}",booking.Status);
                        key=1;

                    }
                }
                if(key==1)
                {
                    Console.WriteLine("Enter the Booking Id to CAncel : ");
                    string id3=Console.ReadLine().ToUpper();
                    foreach(BookingDetails booking in bookingList)
                    {
                        if(id3==booking.BookingId)
                        {
                            booking.Status=Status.Cancelled;
                            currentUser.WalletBalance+=booking.TotalPrice;
                            booking.TotalPrice=0;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("you have no Order history");

                }

            }



        }   
    }
}
