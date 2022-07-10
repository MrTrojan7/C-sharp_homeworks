using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generalization
{
    class Messenger<T, P>
    where T : Message
    where P : Person
    {
        public void SendMessage(P sender, P receiver, T message)
        {
            Console.WriteLine($"Sender: {sender.Name}");
            Console.WriteLine($"Receiver: {receiver.Name}");
            Console.WriteLine($"Message: {message.Text}");
        }
    }
    class Person
    {
        public string Name { get; }
        public Person(string name) => Name = name;
    }

    class Message
    {
        public string Text { get; } // text of message
        public Message(string text) => Text = text;
    }
}
