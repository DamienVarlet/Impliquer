using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;
using Image = UnityEngine.UI.Image;
using JetBrains.Annotations;
using System;

public class LoadEventCard : MonoBehaviour
{
    GameObject[] events;
    GameObject placeToDisp;
    String nameTemplate;
    // Start is called before the first frame update
    void Start()
    {
        events = GameObject.FindGameObjectsWithTag("EventLocation");
        foreach (GameObject e in events){
            Button b = e.GetComponent<Button>();
            b.onClick.AddListener(() => {DispEventOnClick(e);});
        }
        placeToDisp = GameObject.Find("DispEvent");
        nameTemplate = "Events/Ev{0}";
        int lowBound1 = 1;
        int highBound1 = 4;
        LoadEvent(nameTemplate, "event1", lowBound1, highBound1);
    }

    // Update is called once per frame
    void Update()
    {
        int eventRound = Turn.EventRound;
        GameObject currentEvent = events[eventRound];
        Sprite currentSprite = currentEvent.GetComponent<Image>().sprite;
        if (currentSprite == null){
            if(eventRound == 2){
                LoadEvent(nameTemplate, "event2", 4, 7);
            }else if(eventRound == 3){
                LoadEvent(nameTemplate, "event3", 7, 11);
            }else if(eventRound == 4){
                LoadEvent(nameTemplate, "event4", 11, 15);
            }else if(eventRound == 5){
                LoadEvent(nameTemplate, "event5", 15, 22);
            }
        } 
    }

    public void LoadEvent(String nameTemplate, string buttonName, int lowBound, int highBound){
        GameObject eventButton = GameObject.Find(buttonName);
        int eventNumber = Random.Range(lowBound, highBound);
        String eventName = String.Format(nameTemplate, eventNumber);
        Sprite eventImage = Resources.Load<Sprite>(eventName);
        Image eventButtonImage = eventButton.GetComponent<Image>();
        eventButtonImage.sprite = eventImage;
    }

    public void DispEventOnClick(GameObject clickedEvent = null){
        Sprite s = clickedEvent.GetComponent<Image>().sprite;
        Image disp = placeToDisp.GetComponent<Image>();
        if (disp.sprite == null){
            disp.sprite = s;
            placeToDisp.SetActive(true);
        }
        else{
            disp.sprite = null;
            placeToDisp.SetActive(false);
        }
    }

}
