using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dd : MonoBehaviour
{
    int[] mergeSorted;
    int[] arr = new int[] { 18111, 25, 3, 58, 14, 4, 13, 27, 6, 256, 23, 457, 5, 45, 123, 456, 18111 };

    int temp = 0;

    private void Awake()
    {
        mergeSorted = new int[arr.Length];
    }

    private void Start()
    {
        //SelectionSort();
        //MaxSelectionSort();
        //BubbleSort();
        //InsertionSort();
        //QuickSort(0, arr.Length - 1);
        //Quick2(0, arr.Length - 1);
        //R_SplitMethod(arr, 0, arr.Length - 1);
        //Split_test(0, arr.Length - 1);
        Quick_test(arr, 0, arr.Length - 1);
    }

    void SelectionSort()
    {
        int min, index = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            min = 9999;

            for (int j = i; j < arr.Length; j++)
            {
                if (min >= arr[j])
                {
                    min = arr[j];
                    index = j;
                }
            }

            temp = arr[i];
            arr[i] = arr[index];
            arr[index] = temp;
        }
        temp = 0;
    }

    void MaxSelectionSort()
    {
        int max, index = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            max = 1;

            for (int j = i; j < arr.Length; j++)
            {
                if (max <= arr[j])
                {
                    max = arr[j];
                    index = j;
                }
            }

            temp = arr[i];
            arr[i] = arr[index];
            arr[index] = temp;
        }
        temp = 0;
    }

    void BubbleSort()
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            for (int j = 0; j < arr.Length - (i + 1); j++)
            {
                if(arr[j] > arr[j + 1])
                {
                    temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
        temp = 0;
    }

    void InsertionSort()
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            int j = i;
            while (arr[j] > arr[j + 1])
            {
                temp = arr[j];
                arr[j] = arr[j + 1];
                arr[j + 1] = temp;
                if (j == 0) { continue; }
                j--;
            }
        }
        temp = 0;
    }

    void QuickSort(int start, int end)
    {
        //맨 앞의 피봇값을 기준으로 하여 배열을 이분할하여 정렬하는 알고리즘

        if (start >= end) { return; }

        int i = start + 1, j = end;
        int pivot = start;

        while (i <= j)
        {
            while (i <= end && arr[i] <= arr[pivot]) { i++; }
            while (j > start && arr[j] >= arr[pivot]) { j--; }
            if (i > j)
            {
                temp = arr[j];
                arr[j] = arr[pivot];
                arr[pivot] = temp;
            }
            else
            {
                temp = arr[j];
                arr[j] = arr[i];
                arr[i] = temp;
            }
        }

        QuickSort(start, j - 1);
        QuickSort(j + 1, end);
    }

    void Quick2(int start, int end)
    {
        if (start >= end) { return; }

        int i = start + 1, j = end;
        int pivot = start;

        while (i <= j)
        {
            while (arr[i] <= arr[pivot] && i <= end) { i++; }
            while (arr[j] >= arr[pivot] && j > start) { j--; }
            if (i > j)
            {
                temp = arr[j];
                arr[j] = arr[pivot];
                arr[pivot] = temp;
            }
            else
            {
                temp = arr[j];
                arr[j] = arr[i];
                arr[i] = temp;
            }
        }

        Quick2(start, j - 1);
        Quick2(j + 1, end);
    }

    void MergeSort(int[] a, int m, int middle, int n)
    {
        int i = m, j = middle + 1, k = m;

        while (i <= middle && j <= n)
        {
            if (a[i] <= a[j])
            {
                mergeSorted[k] = a[i];
                i++;
            }
            else
            {
                mergeSorted[k] = a[j];
                j++;
            }
            k++;
        }

        //남은 데이터 삽입
        if (i > middle)
        {
            for (int t = j; t <= n; t++)
            {
                mergeSorted[k] = a[t];
                k++;
            }
        }
        else
        {
            for (int t = i; t <= middle; t++)
            {
                mergeSorted[k] = a[t];
                k++;
            }
        }

        for (int t = m; t <= n; t++)
        {
            a[t] = mergeSorted[t];
        }
    }

    void SplitMethod(int[] a, int m, int n)
    {
        if(m < n)
        {
            int middle = (m + n) / 2;
            SplitMethod(a, m, middle);
            SplitMethod(a, middle + 1, n);
            MergeSort(a, m, middle, n);
        }
    }

    void R_MergeSort(int[] a, int m, int middle, int n)
    {
        int i = m, j = middle + 1, k = m;

        while (i <= middle && j <= n)
        {
            if (a[i] >= a[j])
            {
                mergeSorted[k] = a[i];
                i++;
            }
            else
            {
                mergeSorted[k] = a[j];
                j++;
            }
            k++;
        }

        //남은 데이터 삽입
        if (i > middle)
        {
            for (int t = j; t <= n; t++)
            {
                mergeSorted[k] = a[t];
                k++;
            }
        }
        else
        {
            for (int t = i; t <= middle; t++)
            {
                mergeSorted[k] = a[t];
                k++;
            }
        }
        for (int t = m; t <= n; t++)
        {
            a[t] = mergeSorted[t];
        }
    }

    void R_SplitMethod(int[] a, int m, int n)
    {
        if (m < n)
        {
            int middle = (m + n) / 2;
            R_SplitMethod(a, m, middle);
            R_SplitMethod(a, middle + 1, n);
            R_MergeSort(a, m, middle, n);
        }
    }

    void Merge_test(int start, int middle, int end)
    {
        int i = start, j = middle + 1, k = start;

        while (i <= middle && j <= end)
        {
            if (arr[i] <= arr[j])
            {
                mergeSorted[k] = arr[i];
                i++;
            }   
            else
            {
                mergeSorted[k] = arr[j];
                j++;
            }
            k++;
        }
        
        if(i > middle)
        {
            for (int t = j; t <= end; t++)
            {
                mergeSorted[k] = arr[t];
                k++;
            }
        }
        else
        {
            for (int t = i; t <= middle; t++)
            {
                mergeSorted[k] = arr[t];
                k++;
            }
        }

        for (int t = start; t <= end; t++)
        {
            arr[t] = mergeSorted[t];
        }
    }

    void Split_test(int start, int end)
    {
        if(start < end)
        {
            int middle = (start + end) / 2;
            Split_test(start, middle);
            Split_test(middle + 1, end);
            Merge_test(start, middle, end);
        }
    }

    void Quick_test(int[] a, int start, int end)
    {
        int pivot = start, i = start + 1, j = end;

        if (start >= end) { return; }

        while (i <= j)
        {
            while(i <= end && a[pivot] >= a[i]) {
                i++;
            }
            while(j > start && a[pivot] <= a[j]) {
                j--;
            }

            if(i < j)
            {
                temp = a[i];
                a[i] = a[j];
                a[j] = temp;
            } else {
                temp = a[pivot];
                a[pivot] = a[j];
                a[j] = temp;
            }
        }
        Quick_test(a, start, j);
        Quick_test(a, j + 1, end);
    }
}
