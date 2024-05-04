using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task05
{
    // Базовий клас деякого компонента
    abstract class LightNode
    {
        protected string _tagName;
        protected string _displayType;
        protected string _closingType;
        protected List<string> _cssClasses;

        public LightNode(string tagName, string displayType, string closingType, List<string> cssClasses)
        {
            _tagName = tagName;
            _displayType = displayType;
            _closingType = closingType;
            _cssClasses = cssClasses;
        }

        public abstract void Add(LightNode node);
        public abstract void Remove(LightNode node);
        public abstract string OuterHtml();
        public abstract string InnerHtml();

        // Шаблонний метод для хуків життєвого циклу
        public void LifecycleHooks()
        {
            OnCreated();
            OnInserted();
            OnRemoved();
            OnStylesApplied();
            OnClassListApplied();
            OnTextRendered();
        }

        // Абстрактні методи для реалізації в підкласах
        protected abstract void OnCreated();
        protected abstract void OnInserted();
        protected abstract void OnRemoved();
        protected abstract void OnStylesApplied();
        protected abstract void OnClassListApplied();
        protected abstract void OnTextRendered();
    }
}
