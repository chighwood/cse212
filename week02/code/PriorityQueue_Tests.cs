using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PersonQueueTests
{
    [TestMethod]
    // Scenario: Enqueue a single person and then dequeue it.
    // Expected Result: The dequeued item should be the same as the one that was enqueued.
    // Defect(s) Found: None
    public void TestPersonQueue_1()
    {
        // Arrange
        var queue = new PersonQueue();
        string person1 = "Alice";

        // Act
        queue.Enqueue(person1, 1);
        var dequeuedPerson = queue.Dequeue();

        // Assert
        Assert.AreEqual(person1, dequeuedPerson);
    }

    [TestMethod]
    // Scenario: Enqueue two items with different priorities and dequeue them.
    // Expected Result: The dequeued item should be the one with the highest priority.
    // Defect(s) Found: None
    public void TestPersonQueue_2()
    {
        // Arrange
        var queue = new PersonQueue();
        string person1 = "Alice";
        string person2 = "Bob";

        // Act
        queue.Enqueue(person1, 1);
        queue.Enqueue(person2, 3);
        var dequeuedPerson = queue.Dequeue();

        // Assert
        Assert.AreEqual(person2, dequeuedPerson); // Bob should be dequeued because he has higher priority
    }

    [TestMethod]
    // Scenario: Enqueue multiple items with the same priority and dequeue them.
    // Expected Result: The items should be dequeued in the order they were enqueued (FIFO).
    // Defect(s) Found: None
    public void TestPersonQueue_3()
    {
        // Arrange
        var queue = new PersonQueue();
        string person1 = "Alice";
        string person2 = "Bob";
        string person3 = "Charlie";

        // Act
        queue.Enqueue(person1, 2);
        queue.Enqueue(person2, 2);
        queue.Enqueue(person3, 2);

        var dequeuedPerson1 = queue.Dequeue();
        var dequeuedPerson2 = queue.Dequeue();
        var dequeuedPerson3 = queue.Dequeue();

        // Assert
        Assert.AreEqual(person1, dequeuedPerson1); // Alice should be dequeued first (FIFO)
        Assert.AreEqual(person2, dequeuedPerson2); // Bob should be dequeued second
        Assert.AreEqual(person3, dequeuedPerson3); // Charlie should be dequeued third
    }
}