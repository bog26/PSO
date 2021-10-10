using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSO.Model
{
    public class Message
    {
        public int Id { get; set; }
        public string Sender { get; set; }
        public string Receiver { get; set; }

        public string MessageTitle { get; set; }
        public string MessageBody { get; set; }
        /*
        public void MessageSend(string title, string body)
        {

        }
        public string GetMessage()
        {
            string newMessage = "";

            return newMessage;
        }
        */

    }
}
