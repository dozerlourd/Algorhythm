using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuickSort : MonoBehaviour
{
    int[] arr = new int[] { 7111, 1, 32, 8, 6, 214, 9, 0, 40, 5, 2, 4, 10 ,234, 3295, 35, 46, 2, 63, 633, 658, 4, 46, 254, 29 , 910 , 7 ,79, 35, 84, 14, 17 };

    int pivot, temp;

    void Start()
    {
        Quick(0, arr.Length - 1);
    }

    void Quick(int start, int end)
    {
        if (start >= end) { return; }

        pivot = start;
        int i = start + 1;
        int j = end;

        while(i <= j)
        {
            while(i <= end && arr[i] <= arr[pivot]) { i++; }
            while(j > start && arr[j] >= arr[pivot]) { j--; }
            if(i > j)
            {
                temp = arr[j];
                arr[j] = arr[pivot];
                arr[pivot] = temp;
            } else
            {
                temp = arr[j];
                arr[j] = arr[i];
                arr[i] = temp;
            }
        }

        Quick(start, j - 1);
        Quick(j + 1, end);
    }

    void Quick2(int start, int end)
    {
        if (start >= end) { return; }

        int i = start + 1, j = end;
        pivot = start;

        while(i <= j)
        {
            while(arr[i] <= arr[pivot] && i <= end) { i++; }
            while(arr[j] >= arr[pivot] && j > start) { j--; }
            if (i > j)
            {
                temp = arr[j];
                arr[j] = arr[pivot];
                arr[pivot] = temp;
            } else {
                temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }

        Quick2(start, j - 1);
        Quick2(j + 1, end);
    }
}
