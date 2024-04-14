using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;
using Image = UnityEngine.UI.Image;
using JetBrains.Annotations;
using System;

public class LoadEventCard : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        String nameTemplate = "Events/Ev{0}";
        LoadEvent1(nameTemplate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadEvent1(String nameTemplate){
        GameObject event1Button = GameObject.Find("event1");
        int eventNumber = Random.Range(1, 4);
        String event1Name = String.Format(nameTemplate, eventNumber);
        Sprite event1Image = Resources.Load<Sprite>(event1Name);
        Image event1ButtonImage = event1Button.GetComponent<Image>();
        event1ButtonImage.sprite = event1Image;
    }

    public void LoadEvent2(String nameTemplate){
        GameObject event2Button = GameObject.Find("event2");
        int eventNumber = Random.Range(4, 7);
        String event2Name = String.Format(nameTemplate, eventNumber);
        Sprite event2Image = Resources.Load<Sprite>(event2Name);
        Image event2ButtonImage = event2Button.GetComponent<Image>();
        event2ButtonImage.sprite = event2Image;
    }

}
