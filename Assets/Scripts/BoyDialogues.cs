using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEditor.U2D.Animation;
using UnityEngine.SceneManagement;
using UnityEditor.SearchService;

public class BoyDialogues : MonoBehaviour
{
    public TMP_Text speaker;
    public TMP_Text dialoguetext;

    public string[] speakertext;

    public string[] dialogue;

    public GameObject WillChar;

    public int step;

    public GameObject Ella;
    public GameObject Will;

    public GameObject StartGame;

    public GameObject Conversation;

    public GameObject Choice;

    // Update is called once per frame
    void Update()
    {

    }

    public void inDial()
    {
        if (step >= dialogue.Length)
        {
            Will.SetActive(false);
            Conversation.SetActive(false);
            StartGame.SetActive(true);
            Choice.SetActive(true);
            Will.SetActive(true);

        }
        else
        {
            speaker.text = speakertext[step];
            dialoguetext.text = dialogue[step];
            if (speakertext[step] == "Ella")
            {
                Ella.SetActive(true);
                Will.SetActive(false);

            }
            else if (speakertext[step] == "Will")
            {

                Ella.SetActive(false);
                Will.SetActive(true);

            }
            step += 1;
        }
        if (step == 2)
        {
            WillChar.SetActive(true);
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
