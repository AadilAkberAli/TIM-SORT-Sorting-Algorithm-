# TIM-SORT-sorting-algorithm-
Description:-

Tim sort is a hybrid sorting algorithm derived from insertion sort and merge sort.This was first implemented by Tim Peter in 2002 for Python programming language. It was designed to perform well on many kinds of real-world data.Timsort is one of the best sorting algorithms in terms of complexity and stability.

Operation:-

1) A stable sorting algorithm works in O(n Log n) time

2) Used in Java’s Arrays.sort() as well as Python’s sorted() and sort().

3) First sort small pieces using Insertion Sort, then merges the pieces using merge of merge sort.

Runs:-

An ordered sub-array in the input array. At the same time, the order is non-descending or strictly descending.We divide the Array into blocks known as Run.

Minrun:-

An input array is divided into different sub-arrays, count of elements inside a sub-array is defined as a RUN, the minimum value of such runs is a Minrun.A RUN can be either ascending or strictly descending. If elements are decreasing then in place swapping converts them into ascending order, elements that have equal values aren't swapped to maintain stability.Minrun ensures that the input array is split in such a way that when the merge happens, it happens in a perfectly balanced manner.Timsort wants the value of min run to be such that N / MIN_RUN equals to the power of 2 or close to it so that when the merge happens it gets a perfectly balanced merge for example When an input array has 256 elements Tim Sort would like to divide the array into equal sized sub-arrays. 256 / 32 will give us 8 equal sized sub-arrays that perform the perfectly balanced merge.N is the number of elements in an array.

Working:-

Timsort sort those runs using insertion sort one by one and then merge those runs using combine function used in merge sort. If the size of Array is less than run, then Array get sorted just by using Insertion Sort. The size of run may vary from 32 to 64 depending upon the size of the array. Note that merge function performs well when sizes subarrays are powers of 2. The idea is based on the fact that insertion sort performs well for small arrays.

Group Members:-

Aadil Akber Ali(17B-056-SE)

Danish Anjum(17B-037-SE)
