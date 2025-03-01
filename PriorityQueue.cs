using System;
using System.Collections.Generic;
namespace FancyCSharp
{
    public class PriorityQueue<TElement, TPriority>
        where TPriority : IComparable<TPriority>
    {
        private Dictionary<TElement, TPriority> elementPriorityDict;
        private SortedList<TPriority, List<TElement>> priorityElementList;
        private const int DEFAULT_CAPACITY = 16;
        private int capacity;

        public PriorityQueue()
        {
            elementPriorityDict = new Dictionary<TElement, TPriority>(DEFAULT_CAPACITY);
            priorityElementList = new SortedList<TPriority, List<TElement>>();
            capacity = DEFAULT_CAPACITY;
        }

        public void Enqueue(TElement element, TPriority priority)
        {
            if (elementPriorityDict.Count >= capacity)
            {
                ExpandCapacity();
            }
            if (!elementPriorityDict.ContainsKey(element))
            {
                elementPriorityDict.Add(element, priority);
                if (!priorityElementList.ContainsKey(priority))
                {
                    priorityElementList.Add(priority, new List<TElement>());
                }
                priorityElementList[priority].Add(element);
            }
        }

        public TElement Dequeue()
        {
            if (elementPriorityDict.Count == 0)
            {
                throw new InvalidOperationException("Priority queue is empty");
            }
            var firstPriority = priorityElementList.Keys[0];
            var element = priorityElementList[firstPriority][0];
            priorityElementList[firstPriority].RemoveAt(0);
            if (priorityElementList[firstPriority].Count == 0)
            {
                priorityElementList.RemoveAt(0);
            }
            elementPriorityDict.Remove(element);
            if (elementPriorityDict.Count > 0 && elementPriorityDict.Count == capacity / 4)
            {
                ShrinkCapacity();
            }
            return element;
        }

        public TElement Peek()
        {
            if (elementPriorityDict.Count == 0)
            {
                throw new InvalidOperationException("Priority queue is empty");
            }
            var firstPriority = priorityElementList.Keys[0];
            return priorityElementList[firstPriority][0];
        }

        private void ExpandCapacity()
        {
            capacity *= 2;
            var newDict = new Dictionary<TElement, TPriority>(capacity);
            foreach (var kvp in elementPriorityDict)
            {
                newDict.Add(kvp.Key, kvp.Value);
            }
            elementPriorityDict = newDict;
        }

        private void ShrinkCapacity()
        {
            capacity /= 2;
            if (capacity < DEFAULT_CAPACITY)
            {
                capacity = DEFAULT_CAPACITY;
            }
            var newDict = new Dictionary<TElement, TPriority>(capacity);
            foreach (var kvp in elementPriorityDict)
            {
                newDict.Add(kvp.Key, kvp.Value);
            }
            elementPriorityDict = newDict;
        }

        public int Count
        {
            get { return elementPriorityDict.Count; }
        }
    }
}