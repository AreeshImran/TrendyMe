using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneChanger : MonoBehaviour
{
    public GameObject panelUI;

    public void changeScene(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }

    public void panelActivator()
    {
        panelUI.SetActive(true);
    }

    public void panelDeactivator()
    {
        panelUI.SetActive(false);
    }
}
