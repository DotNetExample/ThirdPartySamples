﻿using System;

namespace RabbitMqDemo.Consumer.Receive
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1.Hello World            
            //new _1_HelloWorld().Receive();

            // 2.Work Queue
            //new _2_WorkQueue().Receive();

            // 3.Publish/Subscribe
            //new _3_Publish_Subscribe().Receive();

            // 4.Routing
            new _4_Routing().Receive();

            Console.ReadKey();
        }
    }
}
