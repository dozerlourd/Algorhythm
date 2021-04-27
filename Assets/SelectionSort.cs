using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HCH
{
    public class SelectionSort : MonoBehaviour
    {
        int[] arr = new int[10] { 9, 1, 3, 8, 6, 2, 7, 0, 4, 5 };

        int min, temp, index;

        void Start()
        {
            Selection(arr);
        }

        void Selection(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                min = 9999;

                for (int j = i; j < array.Length; j++)
                {
                    if (min >= array[j])
                    {
                        min = array[j];
                        index = j;
                    }
                }
                temp = array[i];
                array[i] = array[index];
                array[index] = temp;
            }
        }
    }
}