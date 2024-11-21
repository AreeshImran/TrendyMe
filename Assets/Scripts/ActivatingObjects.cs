using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivatingObjects : MonoBehaviour
{

    public GameObject activeGameObject;
    
    public void ActivateObject()
    {
        if (activeGameObject.activeSelf != true)
        {
            GameObject[] gameObjectArray = GameObject.FindGameObjectsWithTag("Dress");

            foreach (GameObject go in gameObjectArray)
            {
                go.SetActive(false);
            }

            activeGameObject.SetActive(true);
        }
        else
        {
            activeGameObject.SetActive(false);
        }
        
    }

}
