using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components
{
    internal interface ISimpleEventPublisher
    {
        void Publish(SimpleEvent eventMessage);
    }

    public class QueuePublisher : ISimpleEventPublisher
    {
        public void Publish(SimpleEvent eventMessage)
        {
            Console.WriteLine("Publish to queue");
            var text = eventMessage.MessageToPass;
            // Publish to queue logic
        }
    }

    public class ApiPublisher : ISimpleEventPublisher
    {
        public void Publish(SimpleEvent eventMessage)
        {
            Console.WriteLine("Publish to API");
            var text = eventMessage.MessageToPass;
            // Publish to API logic
        }
    }

    public class DbPublisher : ISimpleEventPublisher
    {
        public void Publish(SimpleEvent eventMessage)
        {
            Console.WriteLine("Publish to DB");
            var text = eventMessage.MessageToPass;
            // Publish to DB logic
        }
    }

    public class FolderPublisher : ISimpleEventPublisher
    {
        public void Publish(SimpleEvent eventMessage)
        {
            Console.WriteLine("Publish to Folder");
            var text = eventMessage.MessageToPass;
            // Publish to Folder logic
        }
    }

}
