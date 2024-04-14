using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;
using Image = UnityEngine.UI.Image;
using JetBrains.Annotations;

public class LoadEventCard : MonoBehaviour
{
    public GameObject event1Button;
    // Start is called before the first frame update
    void Start()
    {
        LoadEvent1();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadEvent1(){
        Sprite event1Image;
        event1Button = GameObject.Find("event1");
        Debug.Log(event1Button.name + "Bouton event1 chargé");
        String nameTemplate = "Events/Ev{0}";
        int eventNumber = Random.Range(1, 4);
        String event1Name = String.Format(nameTemplate, eventNumber);
        Debug.Log(event1Name);
        event1Image = Resources.Load<Sprite>(event1Name);
        Debug.Log(event1Image.name + "Evènement chargé");
        Image event1ButtonImage = event1Button.GetComponent<Image>();
        event1ButtonImage.sprite = event1Image;
    }
}
