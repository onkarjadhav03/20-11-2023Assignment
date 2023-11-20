Comparison  of Quicksort and Mergesort
Partition of elements in the array : In the merge sort, the array is parted into just 2 halves (i.e. n/2). whereas In case of quick sort, the array is parted into any ratio. There is no compulsion of dividing the array of elements into equal parts in quick sort.
Worst case complexity : The worst case complexity of quick sort is O(n^2) as there is need of lot of comparisons in the worst condition. whereas In merge sort, worst case and average case has same complexities O(n log n).
Usage with datasets : Merge sort can work well on any type of data sets irrespective of its size (either large or small). whereas The quick sort cannot work well with large datasets.
Additional storage space requirement : Merge sort is not in place because it requires additional memory space to store the auxiliary arrays. whereas The quick sort is in place as it doesn’t require any additional storage.
Efficiency : Merge sort is more efficient and works faster than quick sort in case of larger array size or datasets. whereas Quick sort is more efficient and works faster than merge sort in case of smaller array size or datasets.
Sorting method : The quick sort is internal sorting method where the data is sorted in main memory. whereas The merge sort is external sorting method in which the data that is to be sorted cannot be accommodated in the memory and needed auxiliary memory for sorting.
Stability : Merge sort is stable as two elements with equal value appear in the same order in sorted output as they were in the input unsorted array. whereas Quick sort is unstable in this scenario. But it can be made stable using some changes in code.
Preferred for : Quick sort is preferred for arrays. whereas Merge sort is preferred for linked lists.
Locality of reference : Quicksort exhibits good cache locality and this makes quicksort faster than merge sort (in many cases like in virtual memory environment).


Advantages and Disadvantages Quicksort
Quicksort has many advantages, such as being fast, easy to implement, and in-place, which means that it does not require extra space.
Quicksort also has some disadvantages, such as being unstable, sensitive to the choice of the pivot, and vulnerable to the worst case. Quicksort can also cause stack overflow if the recursion depth is too high.

To compare quicksort with other sorting algorithms, you need to consider the trade-offs between speed, memory, and stability. Speed refers to how fast the algorithm can sort the array, memory refers to how much extra space the algorithm requires, and stability refers to whether the algorithm preserves the relative order of equal elements. Quicksort is faster than most other comparison-based sorting algorithms, such as bubble sort, insertion sort, and selection sort, which have a worst case running time of O(n^2). Quicksort is also faster than merge sort, which has a worst case running time of O(n log n), but requires O(n) extra space. Quicksort is not stable, which means that it may change the relative order of equal elements, while merge sort is stable.

Analysing the Time complexity in quick sort 
Analysing the Time complexity in quick sort considering two arrays for comparision 
array-1 [ 9, -3, 5, 2, 6, 8, -6, 1, 3] Arraysize 9 time taken 0.9394 milliseconds 
array-2 [9, 6, 8, -6, 1] Arraysize 5 time taken 1.2259 milliseconds