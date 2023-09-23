using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.Day3
{
    internal interface IMessageService
    {
        void SendMessage(System.String message);
        void SendAudioMessage(string message);
        void SendVideoMessage(System.String message);
        void ReceiveMessage();
        void DeleteMessage();
    }
    public interface IPayments 
    {
            void MakePayment(float amount);
    }
    
    internal class WhatsApp : IMessageService,IPayments
    {

        public void MakePayment(float amount) 
        {
            Console.WriteLine($"Paid Amount {amount}");
        }
        public void DeleteMessage()
        {
            Console.WriteLine("Message Deleted");
        }
        public void ReceiveMessage()
        {
            Console.WriteLine("Method not implemented");
        }
        public void SendAudioMessage(System.String message)
        {
            Console.WriteLine("Method not implemented");
        }
        public void SendVideoMessage(System.String message)
        {
            Console.WriteLine("Method not implemented");
        }
        public void SendMessage(System.String message)
        {
            Console.WriteLine("Method not implemented");
        }
    }
    public class MessageTester 
    {
        public static void TestOne() 
        {
            IMessageService messageservice = new WhatsApp();
            messageservice.SendMessage("Hello");
            messageservice.ReceiveMessage();
        }
        public static void TestTwo() 
        {

        }

    }
}