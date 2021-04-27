using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleSort : MonoBehaviour
{
    int[] arr = new int[10] { 1, 9, 3, 8, 6, 2, 7, 0, 4, 5 };

    int temp2;

    void Start()
    {
        Bubble();
        //HCHSort();
    }

    void Bubble()
    {
        int temp;
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < arr.Length - (i + 1); j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }

    void HCHSort()
    {
        for (int i = 0; i < arr.Length - 2; i++)
        {
            for (int j = 0; j < arr.Length - (i + 2); j++)
            {
                if (arr[j] > arr[j + 2])
                {
                    temp2 = arr[j];
                    arr[j] = arr[j + 2];
                    arr[j + 2] = temp2;
                }

                
            }
        }

        for (int j = 0; j < arr.Length - (j + 1); j++)
        {
            if (arr[j] > arr[j + 1])
            {
                temp2 = arr[j];
                arr[j] = arr[j + 1];
                arr[j + 1] = temp2;
            }
        }
    }
}
