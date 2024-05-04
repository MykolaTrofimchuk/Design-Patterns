using System.Text;
using task05.Command;

namespace task05
{
    // представляє елемент розмітки
    class LightElementNode : LightNode
    {
        private List<LightNode> _children = new List<LightNode>();
        private List<string> _appliedClasses = new List<string>();

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

        // Додавання класу до елемента
        public void AddCssClass(string cssClass)
        {
            if (!_cssClasses.Contains(cssClass))
            {
                _cssClasses.Add(cssClass);
            }
        }

        // Виконання команди
        public void ExecuteCommand(ICommand command)
        {
            command.Execute(this);
        }
    }
}
