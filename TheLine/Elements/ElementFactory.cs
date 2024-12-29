using System;

namespace TheLine.Elements
{
    public static class ElementFactory
    {
        public static Element CreateElement(ElementType type)
        {
            switch (type)
            {
                case ElementType.Fire:
                    return new Fire();
                case ElementType.Water:
                    return new Water();
                case ElementType.Earth:
                    return new Earth();
                case ElementType.Electric:
                    return new Electric();
                case ElementType.Poison:
                    return new Poison();
                default:
                    return new NoElem();
            }
        }
    }
}
