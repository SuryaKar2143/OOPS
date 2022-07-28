using System;
using System.Collections.Generic;
namespace Ecommerce
{
    public static class Operations
    {
       static List<OrderDetail> orderList=new List<OrderDetail>();
       static List<ProdectDetail> productList=new List<ProdectDetail>();
       static List<CustomerDetail> customerList=new List<CustomerDetail>();

        public static void DefaultMethod()
        {        
            ProdectDetail prodect1=new ProdectDetail("Mobile",10,10000,3);
            productList.Add(prodect1);
            
            ProdectDetail prodect2=new ProdectDetail("Tablet",5,15000,2);
            productList.Add(prodect2);

            ProdectDetail prodect3=new ProdectDetail("Camera",3,20000,4);
            productList.Add(prodect3);

            CustomerDetail customer1=new CustomerDetail("Ravi","Chennai",9885858588,"ravi@mail.com");
            customerList.Add(customer1);

            CustomerDetail customer2=new CustomerDetail("Baskaran","Chennai",9888475757,"baskaran@mail.com");
            customerList.Add(customer2);

            OrderDetail order1=new OrderDetail("CID1001","PID101",20000,DateTime.Now,2,OrderStatus.Ordered);
            orderList.Add(order1);

            OrderDetail order2=new OrderDetail("CID1002","PID103",40000,DateTime.Now,2,OrderStatus.Ordered);
            orderList.Add(order2);
            
            

        }
        static CustomerDetail currentUser=null;
        public static void MainMenu()
        { 
            
            string option="yes";
            do{
                Console.WriteLine("Main Menu");
                Console.WriteLine("Choose your Option/n1.Registration/n2.Login/n3.Exit");
                int choice=int.Parse(Console.ReadLine());
               
                switch(choice)
                {
                    case 1:
                    {
                        Console.WriteLine("Registration");
                        Registration();
                        break;
                    }
                    case 2:
                    {
                        Console.WriteLine("Login");
                        Login();
                        break;
                    }
                    case 3:
                    {
                        Console.WriteLine("Exit Main Menu");
                        option="no";
                        break;
                    }
                }

              }while(option=="yes");
    
        }
                public static void  Registration()
              {
                
                Console.WriteLine("Enter Customer Name : ");
                String name=Console.ReadLine();
                Console.WriteLine("Enter Customer's City : ");
                String city=Console.ReadLine();
                Console.WriteLine("Enter Mobile Number : ");
                long mobile=long.Parse(Console.ReadLine());
                Console.WriteLine("Enter Mail Id : ");
                String mailId=Console.ReadLine();

                CustomerDetail customer=new CustomerDetail(name,city,mobile,mailId);
                customerList.Add(customer);

                Console.WriteLine("Your Customer Id is : {0}",customer.CustomerId);

              }

        public static void Login()
        {
                Console.WriteLine("Enter CustomerId: ");
                String ID=Console.ReadLine();
                foreach(CustomerDetail customer in customerList)
                {
                    if(ID==customer.CustomerId)
                    {
                        currentUser=customer;
                        Console.WriteLine("Login Successfull");
                        subMainMenu();

                    }
                }
        }
        public static void subMainMenu()
        {
            
            string option="yes";
            do{
                Console.WriteLine("Sub Main Menu");
                Console.WriteLine("Choose your Option/n1.Show  Details/n2.Wallet Recharge /n3.Purchase/n4.Cancel/n5.Order History/n6.Exit");
                int choice=int.Parse(Console.ReadLine());
               
                switch(choice)
                {
                    case 1:
                    {
                        Console.WriteLine("Show Detail");
                        ShowDetails();
                        break;
                    }
                    case 2:
                    {
                        Console.WriteLine("Wallet Recharge");
                        WalletRecharge();
                        break;
                    }
                    case 3:
                    {
                        Console.WriteLine("Purchased");
                        Purchase();
                        break;
                    }
                    case 4:
                    {
                        Console.WriteLine("Cancel");
                        Cancel();
                        break;
                    }
                    case 5:
                    {
                        Console.WriteLine("Order History");
                        OrderHistory();
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

            static void ShowDetails()
            {
            
                Console.WriteLine("/n-------Customer Details-------/n");
                foreach(CustomerDetail customer in customerList)
                {
                    if(customer.CustomerId==currentUser.CustomerId)
                    {
                        Console.WriteLine("Customer ID      :       {0}",customer.CustomerId);
                        Console.WriteLine("Customer Name    :       {0}",customer.Name);
                        Console.WriteLine("City             :       {0}",customer.City);
                        Console.WriteLine("Mobile Number    :       {0}",customer.Mobile);
                        Console.WriteLine("Mail Id          :       {0}", customer.EmailId);
                    }


                }
            }
            static void WalletRecharge()
            {
                int walletBalance=0;
                Console.WriteLine("Enter the amount do you want to Recharge the Wallet :");
                int amount=int.Parse(Console.ReadLine());
            
                walletBalance=amount+walletBalance;
                Console.WriteLine("Your Wallet Balance is   :   {0}",walletBalance);

            }

            }
            
            static void Purchase()
            {
                Console.WriteLine("Purchase Called");

                Console.WriteLine("/n-----Product Details-------/n");
                foreach(ProdectDetail product in productList )
                {
                
                    Console.WriteLine("Product ID is {0}:",product.ProductId);
                    Console.WriteLine("Product Name : {0}",product.ProductName);
                    Console.WriteLine("Available Stock Quantity : {0}",product.Stock);
                    Console.WriteLine("Price Per Quality  : {0}",product.Price);
                    Console.WriteLine("Shipping Duration  :  {0}",product.Days);

                }
                foreach(ProdectDetail product in productList )
                {

                    
                    Console.WriteLine("Enter the Product Id :");
                    string id=(Console.ReadLine());
                    if(id==product.ProductId)
                        {
                            Console.WriteLine("Enter the Product Quantity");
                            int  quantity=int.Parse(Console.ReadLine());
                            if(quantity>=product.Stock)
                            {
                                double amount1=(quantity*product.Price);
                                if(currentUser.WalletBalance>=amount1)
                                {
                                    currentUser.WalletBalance=(currentUser.WalletBalance-amount1);
                                    Console.WriteLine("Your Current Balance is  :   {0}",currentUser.WalletBalance);
                                    int finalProduct= quantity-product.Stock;
                                    OrderDetail order1=new OrderDetail(currentUser.CustomerId,product.ProductId,amount1,DateTime.Now,quantity,OrderStatus.Ordered);
                                    orderList.Add(order1);
                                    Console.WriteLine("Order placed Successfully");
                                    Console.WriteLine("Your Order Id IS : {0}",order1.OrderId);
                                    Console.WriteLine("Your product will Be delivered on :{0}",DateTime.Now.AddDays(product.Days));
                                    
                                }

                            }
                    }
                
                }

            }
            static void Cancel()
            {
                Console.WriteLine("Cancel Called");
                foreach(OrderDetail order in orderList)
                {
                    Console.WriteLine("Enter your Order Id : ");
                    string id=Console.ReadLine();
                    if(id==order.OrderId)
                    {
                        if((currentUser.CustomerId==order.CustomerId  ))
                        {
                            if(order.OrderStatus==OrderStatus.Ordered)
                            {
                                foreach(ProdectDetail product in productList)
                                {
                                    product.Stock=product.Stock+order.Quality;
                                    currentUser.WalletBalance=currentUser.WalletBalance+order.TotalPrice;
                                    order.OrderStatus=OrderStatus.Cancelled;
                                    Console.WriteLine("Your Order is Cancelled");

                                }


                            }
                        }

                        

                    }
                }


            }
            static void OrderHistory()
            {
                Console.WriteLine("Order history Called");
                Console.WriteLine("/n---------Order Details----------/n");
                foreach(OrderDetail order in orderList)
                {
                    if(currentUser.CustomerId==order.CustomerId)
                    { 
                        Console.WriteLine("Customer ID : {0}",order.CustomerId);
                        Console.WriteLine("Product ID : {0}", order.ProductId);
                        Console.WriteLine("Total Price : {0}",order.TotalPrice);
                        Console.WriteLine("PurchaseDate : {0}",order.PurchaseDate);
                        Console.WriteLine("Quality Purchased : {0}",order.OrderStatus);

                    }
               
            }

            }
        }
        
    }
