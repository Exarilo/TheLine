using System;
using System.Collections.Generic;
using System.Linq;
using TheLine.Drawing;

namespace TheLine.Extensions
{
    public static class SegmentExtensions
    {
        //todo si pas assez de segments a remplacer
        public static void ReplaceSegmentOfType(this IEnumerable<Segment> segments, Element elemToReplace, ElementType newElem, int numberOfElemToReplace)
        {
            if (numberOfElemToReplace <= 0) return;

            foreach (var segment in segments.WhereElementTypeIs(elemToReplace.Type))
            {
                segment.SetElement(newElem);
                numberOfElemToReplace--;


                if (numberOfElemToReplace == 0)
                {
                    break;
                }
            }
        }
        public static void ReplaceSegmentOfType(this IEnumerable<Segment> segments, Element elemToReplace, ElementType newElem) => segments.WhereElementTypeIs(elemToReplace.Type)?.ToList().ForEach(segment => segment.SetElement(newElem));
        
        public static void ReplaceByType(this IEnumerable<Segment> segments, ElementType newElem) =>segments?.ToList().ForEach(segment => segment.SetElement(newElem));

        public static IEnumerable<Segment> WhereElementTypeIs(this IEnumerable<Segment> segments, ElementType elementType)=> segments.Where(segment => segment.CurrentElement.Type == elementType);

        public static IEnumerable<Segment> SelectNumberOfSegments(this IEnumerable<Segment> segments, int numberOfElements) =>segments.Take(numberOfElements);
        
        public static int GetNumberOfElement(this IEnumerable<Segment> segments, ElementType element)=> segments.Count(segment => segment.CurrentElement.Type == element);
        

    }
}
