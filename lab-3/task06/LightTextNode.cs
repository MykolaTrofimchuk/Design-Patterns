using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task06
{
    // представляє текстовий вузол
    class LightTextNode : ILightweightElement
    {
        private string _text;

        public LightTextNode(string text)
        {
            _text = text;
        }

        public int GetSize()
        {
            // Розмір текстового вузла у байтах
            return _text.Length * sizeof(char);
        }

        public string OuterHtml()
        {
            return _text;
        }
    }
}
