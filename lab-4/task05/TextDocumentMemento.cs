﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task05
{
    class TextDocumentMemento
    {
        public string Content { get; private set; }

        public TextDocumentMemento(string content)
        {
            Content = content;
        }
    }
}
