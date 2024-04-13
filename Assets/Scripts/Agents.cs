using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Agents : MonoBehaviour
{
    //int argent;
    public string scene;
    public Button button1;
    public Button button2;
    public Button button3;
    public Button button4;
    public Button button5;
    
    List<GameObject> allCards = new List<GameObject>();
    List<GameObject> deck = new List<GameObject>();
    System.Random random = new System.Random();
    int index;
    
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    public void PlayCard1()
    {
        if(scene == "button1")
        {
            Debug.Log("bouton1 cliqué!");
            int argent = 15;
            Debug.Log("argent = " + argent);
            LoadScene("Game");    
        }  
    }
    public void PlayCard2()
    {
        if(scene == "button2")
        {
            Debug.Log("bouton2 cliqué!");
            LoadScene("Game");     
        } 
    }
    public void PlayCard3()
    {
        if(scene == "button3")
        {
            Debug.Log("bouton3 cliqué!");
            LoadScene("Game");      
        }
    }
    public void PlayCard4()
    {
        if(scene == "button4")
        {
            Debug.Log("bouton4 cliqué!");
            LoadScene("Game");      
        }
    }
    public void PlayCard5()
    {
        if(scene == "button5")
        {
            Debug.Log("bouton cliqué!");
            LoadScene("Game");   
        }
   
    }
    void DrawCards(int number)
    {

        foreach (Transform child in Cards.Instance.transform)
        {
            allCards.Add(child.gameObject);
        }
        
        while(deck.Count<5)
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
        
        if (scene == "AgentsScene")
        {
            DrawCards(5);
            int x = -8;
            foreach (GameObject card in deck)
            {
                DisplayCard(card, x);
                x += 4;
            }
            
        }
    }

    void Update()
    {

    }
}
