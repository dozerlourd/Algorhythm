using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeapSort : MonoBehaviour
{
    int[] arr = new int[9] { 7, 3, 6, 28, 9, 72, 38, 67, 10 };

    int num = 0;

    private void Awake()
    {
        num = arr.Length;
    }
    void Start()
    {
        Heap(arr);
    }

    void Heap(int[] a)
    {
        HeapChange(a);
        //HeapCalc(a);
    }

    void HeapChange(int[] a)
    {
        //전체 트리 구조를 힙 구조로 변화시킴
        for (int i = 0; i < a.Length; i++)
        {
            int c = i;
            do
            {
                int root = (c - 1) / 2;
                if (a[root] < a[c])
                {
                    int temp = a[root];
                    a[root] = a[c];
                    a[c] = temp;
                }
                c = root;
                Debug.Log(a[root]);
            }
            while (c != 0);
        }
    }

    //void HeapCalc(int[] a)
    //{
    //    for (int i = num - 1; i >= 0; i--)
    //    {
    //        int temp = a[0];
    //        a[0] = a[i];
    //        a[i] = temp;
    //        int root = 0;
    //        int c = 1;
    //        do
    //        {
    //            c = 2 * root + 1;
    //            if (a[c] < a[c + 1] && c < i - 1)
    //            {
    //                c = 2;
    //            }
    //        }
    //        while()
    //        {

    //        }
    //    }
    //}
}
