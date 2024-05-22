# Proje 1 - Insertion Sort


## [22,27,16,2,18,6] -> Insertion Sort

[2 | 22, 27, 16, 18, 6] = n 
[2, 6 | 22, 27, 16, 18] = n - 1
[2, 6, 16 | 22, 27, 18] = n - 2
[2, 6, 16, 18 | 22, 27] = n - 3
[2, 6, 16, 18, 22 | 27] = n - 4
[2, 6, 16, 18, 22, 27] = n - 5
                                      +
----------------------------------------
n + (n-1) + (n-2) + (n-3) + (n-4) + (n-5) = 6n - 15 ==> n
Big-O Notation: O(n)

Time Complexity
- Average Case: O(n/2)
- Worst Case: O(n)
- Best Case: O(1)


