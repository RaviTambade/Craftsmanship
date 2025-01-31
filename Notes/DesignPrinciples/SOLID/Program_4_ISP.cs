using System;

//Interface Segregation Principle (ISP)

namespace ISP_1
{
    public interface IOrder
    {
        void AddToCart();
    }
 
    public interface IOnlineOrder
    {
        void CCProcess();
    }
 
 public class OnlineOrder : IOrder, IOnlineOrder
 {
    public void AddToCart()
    {
        //Do Add to Cart
    }
 
    public void CCProcess()
    {
        //process through credit card
    }
 }
 
 public class OfflineOrder : IOrder
 {
    public void AddToCart()
    {
        //Do Add to Cart
    }
 }
  
}