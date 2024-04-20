using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task03
{
    class LightElementNode : LightNode
    {
        private List<LightNode> _children = new List<LightNode>();
        private Dictionary<string, List<EventSubscription>> _eventSubscriptions = new Dictionary<string, List<EventSubscription>>();

        public LightElementNode(string tagName, string displayType, string closingType, List<string> cssClasses) : base(tagName, displayType, closingType, cssClasses)
        {
        }

        public LightElementNode(string tagName, string displayType, string closingType, List<string> cssClasses, List<LightNode> children) : base(tagName, displayType, closingType, cssClasses)
        {
            _children = children;
        }

        public override void Add(LightNode node)
        {
            _children.Add(node);
        }

        public override void Remove(LightNode node)
        {
            _children.Remove(node);
        }

        public void AddEventListener(string eventName, IObserver observer)
        {
            if (!_eventSubscriptions.ContainsKey(eventName))
            {
                _eventSubscriptions[eventName] = new List<EventSubscription>();
            }
            _eventSubscriptions[eventName].Add(new EventSubscription(observer, eventName));
        }

        public void RemoveEventListener(string eventName, IObserver observer)
        {
            if (_eventSubscriptions.ContainsKey(eventName))
            {
                _eventSubscriptions[eventName].RemoveAll(subscription => subscription.Observer == observer);
            }
        }

        public void NotifyEventListeners(string eventName)
        {
            if (_eventSubscriptions.ContainsKey(eventName))
            {
                foreach (var subscription in _eventSubscriptions[eventName])
                {
                    subscription.Observer.HandleEvent(eventName);
                }
            }
        }

        public override string OuterHtml()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append($"<{_tagName} class=\"{string.Join(" ", _cssClasses)}\"");

            foreach (var eventName in _eventSubscriptions.Keys)
            {
                builder.Append($" {eventName}=\"{eventName}_handler()\"");
            }

            builder.Append(">");
            if (_closingType == "open")
            {
                builder.Append(InnerHtml());
            }
            builder.Append($"</{_tagName}>");

            // Додаємо JavaScript обробник подій до HTML
            foreach (var eventName in _eventSubscriptions.Keys)
            {
                builder.Append($"<script>function {eventName}_handler(){{");
                builder.Append($"document.dispatchEvent(new CustomEvent('{eventName}', {{ detail: {{ target: '{_tagName}' }} }}));");
                builder.Append("}</script>");
            }

            return builder.ToString();
        }

        public override string InnerHtml()
        {
            StringBuilder builder = new StringBuilder();
            foreach (var child in _children)
            {
                builder.Append(child.OuterHtml());
            }
            return builder.ToString();
        }
    }
}
