using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Highest Priority is selected
    // Expected Result: pear
    // Defect(s) Found: higher priority item is not being selected first.  Removed -1 in for statement to include all items.  
        public void TestPriorityQueue_1()
        {

            var expectedResult = "pear";
            var priorityQueue = new PriorityQueue();

            priorityQueue.Enqueue("apple", 1);
            priorityQueue.Enqueue("pear", 3);

            var value = priorityQueue.Dequeue();

            Assert.AreEqual(expectedResult, value);

        }

    [TestMethod]
    // Scenario: Higher Priority selected.  When two with same priority, first in is first out.
    // Expected Result: pear, cherry
    // Defect(s) Found: higher priority item is not being selected first.  First item not being removed when both items have equal priority.
    // Added line to Remove item from the queue.  Removed = from >= in the if statement comparing priority.
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("apple", 1);
        priorityQueue.Enqueue("pear", 3);
        priorityQueue.Enqueue("peach", 2);
        priorityQueue.Enqueue("cherry", 3);


        Assert.AreEqual("pear", priorityQueue.Dequeue());
        Assert.AreEqual("cherry", priorityQueue.Dequeue());

    }

    // Add more test cases as needed below.
}