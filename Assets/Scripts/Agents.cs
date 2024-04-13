using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Agents : MonoBehaviour
{
    static int argent;
    static int jaugePolitique = 100;
    static int jaugeNoblesse = 100;
    static int jaugeMilitaire = 100;
    public string scene;
    public Button button1;
    public Button button2;
    public Button button3;
    public Button button4;
    public Button button5;
    static List<string> cardsName = new List<string>();
    List<GameObject> allCards = new List<GameObject>();
    List<GameObject> deck = new List<GameObject>();
    System.Random random = new System.Random();
    int index;
    
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    public void Action(string cardName)
    {
        switch(cardName)
        {
            case "15 pieces":
                argent += 15;
            break;
            case "30 pieces":
                argent += 30;
            break;
            case "50 pieces":
                argent += 50;
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
                Debug.Log("argent = " + argent);
            break;
        }
    }
    public void PlayCard1()
    {
        if(scene == "button1")
        {
            Action(cardsName[0]);
            LoadScene("Game");    
        }  
    }
    public void PlayCard2()
    {
        if(scene == "button2")
        {
            Action(cardsName[1]);
            LoadScene("Game");      
        } 
    }
    public void PlayCard3()
    {
        if(scene == "button3")
        {
            Action(cardsName[2]);
            LoadScene("Game");    
        }
    }
    public void PlayCard4()
    {
        if(scene == "button4")
        {
                Action(cardsName[3]);
                LoadScene("Game");  
        }
    }
    public void PlayCard5()
    {
        if(scene == "button5")
        {
                Action(cardsName[4]);
                LoadScene("Game");
        }
   
    }
    void DrawCards(int number)
    {

        foreach (Transform child in Cards.Instance.transform)
        {
            allCards.Add(child.gameObject);
        }
        
        while(deck.Count<number)
        {
            index = random.Next(0, allCards.Count);
            if(!deck.Contains(allCards[index]))
            {
                deck.Add(allCards[index]);
            }
            
        }
    }

    void DisplayCard(GameObject card, int posX)
    {
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
    
    void Start()
    {
        Debug.Log("Argent1 = " + argent);
        if(scene == "game")
        {
            Debug.Log("Argent = " + argent);
            Debug.Log("Jauge politique = " + jaugePolitique);
            Debug.Log("Jauge noblesse = " + jaugeNoblesse);
            Debug.Log("Jauge militaire = " + jaugeMilitaire);
        }

        if (scene == "AgentsScene")
        {
            DrawCards(5);
            int x = -8;
            foreach (GameObject card in deck)
            {
                DisplayCard(card, x);
                x += 4;
                cardsName.Add(card.name);
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
    }

    void Update()
    {

    }
}
