using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloneObject : MonoBehaviour
{
    public GameObject objectToClone;
    
    public void InstantiateObject()
    {
        int i = 0;
        while (i < 5)
        {
            Instantiate(objectToClone);
            i++;
        }        
    }
}
