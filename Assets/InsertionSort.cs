using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InsertionSort : MonoBehaviour
{
    int[] arr = new int[10] { 9, 1, 3, 8, 6, 2, 7, 0, 4, 5 };

    int temp;

    private void Start()
    {
        Insertion();
        //HCHInsertion();
    }

    void Insertion()
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            int n = i;
            while (arr[n] > arr[n + 1])
            {
                temp = arr[n];
                arr[n] = arr[n + 1];
                arr[n + 1] = temp;
                if (n == 0) { continue; }
                n--;
            }
        }
    }

    //void HCHInsertion()
    //{
    //    for (int i = 0; i < arr.Length - 1; i++)
    //    {
    //        int n = i;
    //        while (arr[n] > arr[n + 1])
    //        {
    //            temp = arr[i];
    //            arr[i] = arr[n + 1];
    //            arr[n + 1] = temp;
    //            Debug.Log("바뀜");
    //            if (n == 0) { break; }
    //            n--;
    //        }
    //        //값 저장
    //        //if(i != n + 1)
    //        //{
    //        //    temp = arr[i];
    //        //    arr[i] = arr[n + 1];
    //        //    arr[n + 1] = temp;
    //        //    Debug.Log("바뀜");
    //        //}
    //    }
    //}
}
