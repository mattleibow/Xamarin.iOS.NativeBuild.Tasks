﻿using UIKit;

namespace BuildTaskTester
{
    public class Application
    {
        // This is the main entry point of the application.
        static void Main(string[] args)
        {
            var t = new Square.SocketRocket.WebSocket();

            // if you want to use a different Application Delegate class from "AppDelegate"
            // you can specify it here.
            UIApplication.Main(args, null, "AppDelegate");
        }
    }
}