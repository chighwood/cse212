/// <summary>
/// A basic implementation of a Queue
/// </summary>

using System;
using System.Collections.Generic;

public class PersonQueue
{
    private List<(string Name, int Priority)> _queue = new List<(string, int)>();

    // Add a person with their priority to the queue
    public void Enqueue(string name, int priority)
    {
        _queue.Add((name, priority)); // Add the person to the end of the queue
    }

    // Remove the person with the highest priority from the queue
    public string Dequeue()
    {
        if (_queue.Count == 0)
        {
            throw new InvalidOperationException("Queue is empty.");
        }

        // Find the person with the highest priority
        var highestPriorityPerson = _queue[0];

        foreach (var person in _queue)
        {
            if (person.Priority > highestPriorityPerson.Priority)
            {
                highestPriorityPerson = person;
            }
        }

        // Remove the highest priority person from the list
        _queue.Remove(highestPriorityPerson);

        return highestPriorityPerson.Name;
    }

    // Check if the queue is empty
    public bool IsEmpty()
    {
        return _queue.Count == 0;
    }

    // Get the number of people in the queue
    public int Length => _queue.Count;
}
