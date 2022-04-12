using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{
    internal class Message
    {
        int duration=2000;
        string msgTitle ;
        string msgBody;
        MESSAGE_TYPE msgType ;


        public Message(string title, string body, MESSAGE_TYPE type,int duration)
        {
            this.msgTitle = title;
            this.msgBody = body;
            this.msgType = type;
            this.duration = duration;
        }

        public Message(string title, string body, MESSAGE_TYPE type) {
            this.msgTitle= title;
            this.msgBody= body;
            this.msgType = type;
            this.duration = 2000;
        }

        public Message(string title, string body)
        {
            this.msgTitle = title;
            this.msgBody = body;
            this.msgType = MESSAGE_TYPE.INFO;
            this.duration = 2000;
        }

        public Message(string title, string body,int duration)
        {
            this.msgTitle = title;
            this.msgBody = body;
            this.duration = duration;
            this.msgType = MESSAGE_TYPE.INFO;
        }

        public void Show() {
            Console.WriteLine($"Message Title:{msgTitle}, Message Body: {msgBody}, MessageType {msgType}");
        }


        public void Hide() {
            Console.WriteLine($"Hiding Message...done");

        }

    }

    enum MESSAGE_TYPE
    {
       ERROR,
       SUCCESS,
       INFO,
       WARN,

    }
}
