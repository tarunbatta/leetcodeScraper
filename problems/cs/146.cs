// Url:https://leetcode.com/problems/lru-cache

/*
146. LRU Cache
Medium

Design and implement a data structure for Least Recently Used (LRU) cache. It should support the following operations: get and put.

get(key) - Get the value (will always be positive) of the key if the key exists in the cache, otherwise return -1.
put(key, value) - Set or insert the value if the key is not already present. When the cache reached its capacity, it should invalidate the least recently used item before inserting a new item.

The cache is initialized with a positive capacity.

Follow up:
Could you do both operations in O(1) time complexity?

Example:

LRUCache cache = new LRUCache( 2 /* capacity */ );

cache.put(1, 1);
cache.put(2, 2);
cache.get(1);       // returns 1
cache.put(3, 3);    // evicts key 2
cache.get(2);       // returns -1 (not found)
cache.put(4, 4);    // evicts key 1
cache.get(1);       // returns -1 (not found)
cache.get(3);       // returns 3
cache.get(4);       // returns 4


&#xA0;
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution146
{
    public class LRUCache {​    public LRUCache(int capacity) { } public int Get(int key) { } public void Put(int key, int value) { } }​/** * Your LRUCache object will be instantiated and called as such: * LRUCache obj = new LRUCache(capacity); * int param_1 = obj.Get(key); * obj.Put(key,value); *
}
