using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MergeSort : MonoBehaviour
{
    int[] sorted = new int[8];

    int[] arr = new int[] { 7, 6, 5, 8, 3, 5, 9, 1 };

    void Start()
    {
        StartCoroutine(E_Merge());
    }

    void Merge(int[] a, int m, int middle, int n)
    {
        int i = m, j = middle + 1, k = m;
        while(i <= middle && j <= n)
        {
            if(a[i] <= a[j])
            {
                sorted[k] = a[i];
                i++;
            } else {
                sorted[k] = a[j];
                j++;
            }
            k++;
        }

        //남은 데이터 삽입
        if (i > middle)
        {
            for (int t = j; t <= n; t++)
            {
                sorted[k] = a[t];
                k++;
            }
        } else {
            for (int t = i; t <= middle; t++)
            {
                sorted[k] = a[t];
                k++;
            }
        }
        for (int t = m; t <= n; t++)
        {
            a[t] = sorted[t];
        }
    }

    void MergeSortMethod(int[] a, int m, int n)
    {
        if(m < n)
        {
            int middle = (m + n) / 2;
            MergeSortMethod(a, m, middle);
            MergeSortMethod(a, middle + 1, n);
            Merge(a, m, middle, n);
        }
    }

    IEnumerator E_Merge()
    {
        MergeSortMethod(arr, 0, arr.Length - 1);
        for (int t = 0; t < arr.Length; t++)
        {
            Debug.Log(arr[t]);
        }
        yield return null;
    }
}
