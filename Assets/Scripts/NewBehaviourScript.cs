using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    //int x = 10;
    //int y = 11;
    int[] arr = new int[10];

    void Start()
    {
        
        llenadou();
        imprime();

        
    }

    public void llenadou()
    {
        for (int i = 0; i < 10; i++) 
        {
            
            arr[i] = i * 2;
        }
    }

    public void imprime()
    {
        for (int i = 0; i < 10; i++)
        {

            Debug.Log(arr[i]);
        }
    }

}
