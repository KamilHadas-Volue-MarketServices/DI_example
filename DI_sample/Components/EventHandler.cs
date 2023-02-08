using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components
{
    public interface IEventHandler
    {
        void PublishEvent(SimpleEvent simpleEvent);
    }

    public class EventHandler : IEventHandler
    {
        private readonly List<ISimpleEventPublisher> _simpleEventPublisher;

        public EventHandler(IEnumerable<ISimpleEventPublisher> simpleEventPublisher)
        {
            _simpleEventPublisher = simpleEventPublisher.ToList();
        }

        public void PublishEvent(SimpleEvent simpleEvent)
        {

            _simpleEventPublisher.ForEach(ep => ep.Publish(simpleEvent));
        }
    }
}
