using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Choices : MonoBehaviour
{
    public GameObject choice;

    public GameObject convo1;

    public GameObject convo2;

    public GameObject convo3;

    public GameObject Will;

    public GameObject Ella;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void choiceSelec1()
    {
        convo1.SetActive(false);
        convo2.SetActive(true);
        choice.SetActive(false);
        Will.SetActive(false);
        Ella.SetActive(true);

    }

    public void choiceSelec2()
    {
        convo1.SetActive(false);
        convo3.SetActive(true);
        choice.SetActive(false);
        Will.SetActive(false);
        Ella.SetActive(true);
    }
}
