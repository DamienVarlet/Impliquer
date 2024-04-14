using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;
using UnityEngine.TextCore.Text;
using UnityEngine.UI;
using UnityEngine.UIElements;
using Image = UnityEngine.UI.Image;
using Button = UnityEngine.UI.Button;

public class LoadEventCard : MonoBehaviour
{
    // Start is called before the first frame update
    public Sprite eventCard;
    public UnityEngine.UI.Button event1Button;
    void Start()
    {
        LoadEvent1();

    }

    public void LoadEvent1(){
        event1Button = GameObject.Find("Event1").GetComponent<Button>();
        Image event1ButtonImage = event1Button.GetComponent<Image>();
        int eventNumber = UnityEngine.Random.Range(1, 4);
        String nameTemplate = "Images/Events/Ev{0}";
        String eventName = String.Format(nameTemplate, eventNumber);
        Debug.Log(eventName);
        eventCard = Resources.Load<Sprite>(eventName);
        // Image[] test = Resources.LoadAll<Image>("");
        // Debug.Log(test.Length);
        // foreach (Image s in test){
        //     Debug.Log(s.name);
        // }
        event1ButtonImage.sprite = eventCard;
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
