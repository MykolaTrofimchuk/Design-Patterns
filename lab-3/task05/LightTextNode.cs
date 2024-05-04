using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task05
{
    // представляє текстовий вузол
    class LightTextNode : LightNode
    {
        private string _text;

        public LightTextNode(string text) : base(null, null, null, null)
        {
            _text = text;
        }

        public override void Add(LightNode node)
        {
            throw new InvalidOperationException("Cannot add child to text node");
        }

        public override void Remove(LightNode node)
        {
            throw new InvalidOperationException("Cannot remove child from text node");
        }

        public override string OuterHtml()
        {
            return _text;
        }

        public override string InnerHtml()
        {
            return _text;
        }

        // Реалізація конкретних кроків хуків життєвого циклу
        protected override void OnCreated() { Console.WriteLine("Text node created"); }
        protected override void OnInserted() { Console.WriteLine("Text node inserted into document"); }
        protected override void OnRemoved() { Console.WriteLine("Text node removed from document"); }
        protected override void OnStylesApplied() { Console.WriteLine("Styles applied to text node"); }
        protected override void OnClassListApplied() { Console.WriteLine("Class list applied to text node"); }
        protected override void OnTextRendered() { Console.WriteLine("Text rendered for text node"); }
    }
}
