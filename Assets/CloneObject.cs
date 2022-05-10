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

        GameObject clon;
        for (int i = 0; i < 14; i++)
        {           
            clon = Instantiate(objectToClone);
            clon.transform.Rotate(0, 45 * i, 0);
            clon.transform.Translate(i, i, 0);
            
            Destroy(clon, 5f);
        }

    }
}
