using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonActivator : MonoBehaviour
{
    public GameObject activeGameObject;
    public GameObject OutfitsButton;


    public void ActivateButton()
    {

        if (activeGameObject.activeSelf != true)
        {
            activeGameObject.SetActive(true);
            OutfitsButton.SetActive(false);

        }
        else
        {
 

            activeGameObject.SetActive(false);
            OutfitsButton.SetActive(true);
        }
    }
}
