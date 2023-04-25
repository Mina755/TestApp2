using DocumentFormat.OpenXml.Wordprocessing;
using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace TestApp2
{
    public class MyHub : Hub
    {
        public void SendMessage(string message)
        {
            //Clients.All.broadcastMessage(name, message);
        }
    }
}