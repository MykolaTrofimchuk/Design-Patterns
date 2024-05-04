using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task05
{
    // представляє елемент розмітки
    class LightElementNode : LightNode
    {
        private List<LightNode> _children = new List<LightNode>();

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

        public override string OuterHtml()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append($"<{_tagName} class=\"{string.Join(" ", _cssClasses)}\">");
            if (_closingType == "open")
            {
                builder.Append(InnerHtml());
            }
            builder.Append($"</{_tagName}>");
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

        // Реалізація конкретних кроків хуків життєвого циклу
        protected override void OnCreated() { Console.WriteLine($"Element {_tagName} created"); }
        protected override void OnInserted() { Console.WriteLine($"Element {_tagName} inserted into document"); }
        protected override void OnRemoved() { Console.WriteLine($"Element {_tagName} removed from document"); }
        protected override void OnStylesApplied() { Console.WriteLine($"Styles applied to element {_tagName}"); }
        protected override void OnClassListApplied() { Console.WriteLine($"Class list applied to element {_tagName}"); }
        protected override void OnTextRendered() { Console.WriteLine($"Text rendered for element {_tagName}"); }

    }

}
