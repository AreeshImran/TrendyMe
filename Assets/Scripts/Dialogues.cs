using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEditor.U2D.Animation;
using UnityEngine.SceneManagement;
using UnityEditor.SearchService;

public class Dialogues : MonoBehaviour
{
    public TMP_Text speaker;
    public TMP_Text dialoguetext;

    public string[] speakertext;

    public string[] dialogue;

    public int step;

    public GameObject Ella;
    public GameObject Zoe;

    public GameObject StartGame;

    public GameObject Conversation;

    // Update is called once per frame
    void Update()
    {

    }

    public void inDial()
    {
        if(step >= dialogue.Length)
        {
            Zoe.SetActive(false);
            Conversation.SetActive(false);
            StartGame.SetActive(true);
        }
        else
        {
            speaker.text = speakertext[step];
            dialoguetext.text = dialogue[step];
            if (speakertext[step] == "Ella")
            {
                Ella.SetActive(true);
                Zoe.SetActive(false);

            }
            else if (speakertext[step] == "Zoe")
            {

                Ella.SetActive(false);
                Zoe.SetActive(true);

            }
            step += 1;
        }
    }

    public void ChangetheScene()
    {
        changeScene(2);
    }

    public void changeScene(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }
}
