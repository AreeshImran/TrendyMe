using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class destroyprefabonstart : MonoBehaviour
{
    public GameObject character;

    public void savecharandscene(int sceneID)
    {
            PrefabUtility.SaveAsPrefabAsset(character, "Assets/Resources/savedchar.prefab");
            SceneManager.LoadScene(sceneID);
        

    }
}
