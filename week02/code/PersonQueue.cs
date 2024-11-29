/// <summary>
/// A basic implementation of a Queue
/// </summary>

using System;
using System.Collections.Generic;

using System;
using System.Collections.Generic;

public class PersonQueue
{
    private List<(string Name, int Turns)> _queue = new();

    // Adds a person to the queue
    public void Enqueue(string name, int turns)
    {
        _queue.Add((name, turns));
    }

    // Removes and returns the person with the highest priority (first if tied)
    public (string Name, int Turns) Dequeue()
    {
        if (_queue.Count == 0)
        {
            throw new InvalidOperationException("Queue is empty.");
        }

        var highestPriorityPerson = _queue[0];
        int indexToRemove = 0;

        for (int i = 1; i < _queue.Count; i++)
        {
            if (_queue[i].Turns > highestPriorityPerson.Turns)
            {
                highestPriorityPerson = _queue[i];
                indexToRemove = i;
            }
        }

        _queue.RemoveAt(indexToRemove);
        return highestPriorityPerson;
    }

    // Checks if the queue is empty
    public bool IsEmpty()
    {
        return _queue.Count == 0;
    }

    // Returns the number of people in the queue
    public int Length => _queue.Count;
}

