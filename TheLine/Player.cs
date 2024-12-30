using System;
using System.Collections.Generic;
using TheLine.Elements;

namespace TheLine
{
    public class Player
    {
        private int hp;
        public event Action<ElementType, ElementType> OnElementChanged;
        private List<Element> elements = new List<Element>();

        public Player(int hp)
        {
            this.hp = hp;
        }


        public void AddElements(ElementType elementType, int number)
        {
            for (int i = 0; i < number; i++)
            {
                elements.Add(ElementFactory.CreateElement(elementType));
            }
        }
    }
}