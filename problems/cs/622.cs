// Url:https://leetcode.com/problems/design-circular-queue

/*
622. Design Circular Queue
Medium

Design your implementation of the circular queue. The circular queue is a linear data structure in which the operations are performed based on FIFO (First In First Out) principle and the last position is connected back to the first position to make a circle. It is also called &quot;Ring Buffer&quot;.

One of the benefits of the circular queue is that we can make use of the spaces in front of the queue. In a normal queue, once the queue becomes full, we cannot insert the next element even if there is a space in front of the queue. But using the circular queue, we can use the space to store new values.

Your implementation should support following operations:


	MyCircularQueue(k): Constructor, set the size of the queue to be k.
	Front: Get the front item from the queue. If the queue is empty, return -1.
	Rear: Get the last item from the queue. If the queue is empty, return -1.
	enQueue(value): Insert an element into the circular queue. Return true if the operation is successful.
	deQueue(): Delete an element from the circular queue. Return true if the operation is successful.
	isEmpty(): Checks whether the circular queue is empty or not.
	isFull(): Checks whether the circular queue is full or not.


&#xA0;

Example:

MyCircularQueue circularQueue = new MyCircularQueue(3); // set the size to be 3
circularQueue.enQueue(1); &#xA0;// return true
circularQueue.enQueue(2); &#xA0;// return true
circularQueue.enQueue(3); &#xA0;// return true
circularQueue.enQueue(4); &#xA0;// return false, the queue is full
circularQueue.Rear(); &#xA0;// return 3
circularQueue.isFull(); &#xA0;// return true
circularQueue.deQueue(); &#xA0;// return true
circularQueue.enQueue(4); &#xA0;// return true
circularQueue.Rear(); &#xA0;// return 4

&#xA0;

Note:


	All values will be in the range of [0, 1000].
	The number of operations will be in the range of&#xA0;[1, 1000].
	Please do not use the built-in Queue library.
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution622
{
    public class MyCircularQueue {​    /** Initialize your data structure here. Set the size of the queue to be k. */    public MyCircularQueue(int k) { }        /** Insert an element into the circular queue. Return true if the operation is successful. */    public bool EnQueue(int value) { }        /** Delete an element from the circular queue. Return true if the operation is successful. */    public bool DeQueue() { }        /** Get the front item from the queue. */    public int Front() { }        /** Get the last item from the queue. */    public int Rear() { }        /** Checks whether the circular queue is empty or not. */    public bool IsEmpty() { }        /** Checks whether the circular queue is full or not. */    public bool IsFull() { } }​/** * Your MyCircularQueue object will be instantiated and called as such: * MyCircularQueue obj = new MyCircularQueue(k); * bool param_1 = obj.EnQueue(value); * bool param_2 = obj.DeQueue(); * int param_3 = obj.Front(); * int param_4 = obj.Rear(); * bool param_5 = obj.IsEmpty(); * bool param_6 = obj.IsFull(); *
}
