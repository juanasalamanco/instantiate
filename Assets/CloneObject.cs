using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloneObject : MonoBehaviour
{
    public GameObject objectToClone;
    //public GameObject clon;

    public void InstantiateObject()
    {
        /*
        int i = 0;
        while (i < 5)
        {
            Instantiate(objectToClone);
            i++;
        }
        */    

        for(int i = 0; i < 13; i++)
        {
            GameObject clon;
            clon = Instantiate(objectToClone);
            Destroy(clon, 1);
        }

    }
}
