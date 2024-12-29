using System.Drawing;

namespace TheLine
{
    public enum ElementType
    {
        None,
        Fire,
        Water,
        Earth,
        Electric,
        Poison,
    }

    public abstract class Element
    {
        public ElementType Type { get; }
        public string Name { get; }

        protected Element(ElementType type, string name)
        {
            Type = type;
            Name = name;
        }
    }
}
