using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Agents : MonoBehaviour
{
    static int money;
    static int jaugePolitique = 100;
    static int jaugeNoblesse = 100;
    static int jaugeMilitaire = 100;
    static int eventRound = 1;
    static int round = 1;
    public string scene;
    public Button button1;
    public Button button2;
    public Button button3;
    public Button button4;
    public Button button5;
    public Button buttonStartRound;
    static List<string> deck = new List<string>();
    static List<GameObject> allCards = new List<GameObject>();
    System.Random random = new System.Random();
    int index;
    int x;
    
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    public void Action(string cardName)
    {
        switch(cardName)
        {
            case "15 pieces":
                money += 15;
            break;
            case "30 pieces":
                money += 30;
            break;
            case "50 pieces":
                money += 50;
            break;     
            case "Complot_5p":
                jaugePolitique += 10;
            break;
            case "Complot_10p":
                jaugePolitique += 20;
            break;
            case "Complot_20p":
                jaugePolitique += 40;
            break;
            case "Discours_5p":
                jaugePolitique += 10;
            break;
            case "Discours_10p":
                jaugePolitique += 20;
            break;
            case "Discours_20p":
                jaugePolitique += 40;
            break;
            case "Assasinat_5p":
                jaugePolitique += 10;
            break;
            case "Assasinat_10p":
                jaugePolitique += 20;
            break;
            case "Assasinat_20p":
                jaugePolitique += 40;
            break;
            case "Privilèges_5p":
                jaugeNoblesse += 10;
            break;
            case "Privilèges_10p":
                jaugeNoblesse += 20;
            break;
            case "Privilèges_20p":
                jaugeNoblesse += 40;
            break;
            case "Mariage_5p":
                jaugeNoblesse += 10;
            break;
            case "Mariage_10p":
                jaugeNoblesse += 20;
            break;
            case "Mariage_20p":
                jaugeNoblesse += 40;
            break;
            case "Pot de vin_5p":
                jaugeNoblesse += 10;
            break;
            case "Pot de vin_10p":
                jaugeNoblesse += 20;
            break;
            case "Pot de vin_20p":
                jaugeNoblesse += 40;
            break;
            case "Declaration de guerre_5p":
                jaugeMilitaire += 10;
            break; 
            case "Declaration de guerre_10p":
                jaugeMilitaire += 20;
            break;   
            case "Declaration de guerre_20p":
                jaugeMilitaire += 40;
            break;
            case "Mutinerie_5p":
                jaugeMilitaire += 10;
            break; 
            case "Mutinerie_10p":
                jaugeMilitaire += 20;
            break;   
            case "Mutinerie_20p":
                jaugeMilitaire += 40;
            break;
            case "Alliance_5p":
                jaugeMilitaire += 10;
            break; 
            case "Alliance_10p":
                jaugeMilitaire += 20;
            break;   
            case "Alliance_20p":
                jaugeMilitaire += 40;
            break;
            default:
                Debug.Log("argent = " + money);
            break;
        }
    }
    public void PlayCard1()
    {
        if(scene == "button1")
        {
            Action(deck[0]);
            deck.RemoveAt(0);
            LoadScene("Game");    
        }  
    }
    public void PlayCard2()
    {
        if(scene == "button2")
        {
            Action(deck[1]);
            deck.RemoveAt(1);
            LoadScene("Game");      
        } 
    }
    public void PlayCard3()
    {
        if(scene == "button3")
        {
            Action(deck[2]);
            deck.RemoveAt(2);
            LoadScene("Game");    
        }
    }
    public void PlayCard4()
    {
        if(scene == "button4")
        {
                Action(deck[3]);
                deck.RemoveAt(3);
                LoadScene("Game");  
        }
    }
    public void PlayCard5()
    {
        if(scene == "button5")
        {
                Action(deck[4]);
                deck.RemoveAt(4);
                LoadScene("Game");
        }
   
    }
    void DrawCards(int number)
    {
        deck.Clear();
        allCards.Clear();
        foreach (Transform child in Cards.Instance.transform)
        {
            allCards.Add(child.gameObject);
        }
        
        while(deck.Count<number)
        {
            index = random.Next(0, allCards.Count);
            if(!deck.Contains(allCards[index].name) && allCards != null)
            {
                deck.Add(allCards[index].name);
            }
            
        }
    }

    void DisplayCard(string cardName, int posX)
    {
        GameObject card = GameObject.Find(cardName);
        Vector2 position = card.transform.position;
        Vector2 scale = card.transform.localScale;

        position.x = posX;
        position.y = 0;
        scale.x = 0.3f;
        scale.y = 0.3f;

        card.transform.position = position;
        card.transform.localScale = scale;
        card.GetComponent<Renderer>().enabled = true;
    }

    void StartRound()
    {
        LoadScene("AgentsScene");
    }
    
    void Start()
    {
        if(scene == "game")
        {
            /*
            Debug.Log("Argent = " + money);
            Debug.Log("Jauge politique = " + jaugePolitique);
            Debug.Log("Jauge noblesse = " + jaugeNoblesse);
            Debug.Log("Jauge militaire = " + jaugeMilitaire);
            */
            Debug.Log("Tour : " + round);
        }

        if (scene == "AgentsScene")
        {
            switch(round){
            case 1:
                DrawCards(5);
                x = -8;
                foreach (string cardName in deck)
                {
                    DisplayCard(cardName, x);
                    x += 4;
                }
                round = 2;
            break;
            case 2:
                x = -8;
                foreach (string cardName in deck)
                {
                    DisplayCard(cardName, x);
                    x += 4;
                }
                round = 3;
                
            break;
            case 3:
                x = -8;
                foreach (string cardName in deck)
                {
                    DisplayCard(cardName, x);
                    x += 4;
                }
                round = 1;
                eventRound += 1;
            break;
            }
        }
        if (scene == "button1" || scene == "button2" || scene == "button3" || scene == "button4" || scene == "button5"){
            button1 = GameObject.Find("button1").GetComponent<Button>();
            button1.onClick.AddListener(PlayCard1);

            button2 = GameObject.Find("button2").GetComponent<Button>();
            button2.onClick.AddListener(PlayCard2);

            button3 = GameObject.Find("button3").GetComponent<Button>();
            button3.onClick.AddListener(PlayCard3);

            button4 = GameObject.Find("button4").GetComponent<Button>();
            button4.onClick.AddListener(PlayCard4);

            button5 = GameObject.Find("button5").GetComponent<Button>();
            button5.onClick.AddListener(PlayCard5);
        }
        if (scene == "buttonStartRound")
        {
            buttonStartRound = GameObject.Find("buttonStartRound").GetComponent<Button>();
            buttonStartRound.onClick.AddListener(StartRound);
        }
    }

    void Update()
    {

    }
}
