using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class intoSalon : MonoBehaviour
{
    public GameObject character;

    public void Salon(int sceneID)
    {
        character.SetActive(false);
        SceneManager.LoadScene(sceneID);
    }
}
