using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    interface ISender {
        void Send(string message);
    }

    class MessageSender : ISender
    {
        public void Send(string message)
        {
            Console.WriteLine(message);
        }
    }
    class EmailSender : ISender
    {
        public void Send(string message)
        {
            Console.WriteLine(message);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ISender[] senders = new ISender[2];
            senders[0] = new MessageSender();
            senders[1] = new EmailSender();
            for (int i = 0; i < senders.Length; i++)
            {
                senders[i].Send("Hello");
            }
            Console.ReadLine();
        }
    }
}
