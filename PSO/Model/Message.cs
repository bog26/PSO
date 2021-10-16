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
        public DateTime MessageTime { get; set; }

        public string MessageStatus { get; set; }
        public bool IsEncrypted { get; set; }
        public Message()
        {
            MessageStatus = "sent";
            IsEncrypted = false;
        }
        public Message(string encryption)
        {
            MessageStatus = "sent";
            if(encryption == "true")
            {
                IsEncrypted = true;
            }
            else 
            {
                IsEncrypted = false;
            }
        }
        public void ReadMessage()
        {
            MessageStatus = "read";
        }
        public void DeleteMessage()
        {
            MessageStatus = "deleted";
        }
        public void SpamMessage()
        {
            MessageStatus = "spam";
        }


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
