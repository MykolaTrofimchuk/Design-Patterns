using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task06
{
    // Клас, що представляє елемент розмітки
    class LightElementNode : ILightweightElement
    {
        private string _tagName;
        private List<ILightweightElement> _children = new List<ILightweightElement>();

        public LightElementNode(string tagName, List<ILightweightElement> children)
        {
            _tagName = tagName;
            _children = children;
        }

        public int GetSize()
        {
            int size = 0;
            foreach (var child in _children)
            {
                size += child.GetSize();
            }
            return size;
        }

        public string OuterHtml()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine($"<{_tagName}>");
            foreach (var child in _children)
            {
                builder.AppendLine(child.OuterHtml());
            }
            builder.AppendLine($"</{_tagName}>");
            return builder.ToString();
        }
    }
}
