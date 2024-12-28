using System;
using System.Collections.Generic;
using System.Linq;
using TheLine.Drawing;

namespace TheLine.Extensions
{
    public static class SegmentExtensions
    {
        //todo si pas assez de segments a remplacer
        public static void ReplaceSegmentOfType(this IEnumerable<Segment> segments, Element elemToReplace, Element newElem, int numberOfElemToReplace)
        {
            if (numberOfElemToReplace <= 0) return;

            foreach (var segment in segments.WhereElementIs(elemToReplace))
            {
                segment.SetElement(newElem);
                numberOfElemToReplace--;


                if (numberOfElemToReplace == 0)
                {
                    break;
                }
            }
        }
        public static void ReplaceSegmentOfType(this IEnumerable<Segment> segments, Element elemToReplace, Element newElem) => segments.WhereElementIs(elemToReplace)?.ToList().ForEach(segment => segment.SetElement(newElem));
        
        public static void ReplaceByType(this IEnumerable<Segment> segments, Element newElem) => segments?.ToList().ForEach(segment => segment.SetElement(newElem));

        public static IEnumerable<Segment> WhereElementIs(this IEnumerable<Segment> segments, Element element)=> segments.Where(segment => segment.CurrentElement == element);

        public static IEnumerable<Segment> SelectNumberOfSegments(this IEnumerable<Segment> segments, int numberOfElements) =>segments.Take(numberOfElements);
        
        public static int GetNumberOfElement(this IEnumerable<Segment> segments, Element element)=> segments.Count(segment => segment.CurrentElement == element);
        

    }
}
