using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task05
{
    class TextEditor
    {
        private TextDocument _document;

        public TextEditor(string content)
        {
            _document = new TextDocument(content);
        }

        // Функція для збереження стану документу
        public TextDocumentMemento Save()
        {
            return new TextDocumentMemento(_document.Content);
        }

        // Функція для відновлення стану документу
        public void Restore(TextDocumentMemento memento)
        {
            _document.Content = memento.Content;
        }

        public void SetContent(string content)
        {
            _document.Content = content;
        }

        public override string ToString()
        {
            return _document.ToString();
        }
    }
}
