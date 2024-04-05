using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Agents : MonoBehaviour
{
    public int argent = 5;
    List<GameObject> allCards = new List<GameObject>();
    List<GameObject> deck = new List<GameObject>();
    System.Random random = new System.Random();
    int index;
    public string scene;

    void DrawCards(int number)
    {

        foreach (Transform child in Cards.Instance.transform)
        {
            allCards.Add(child.gameObject);
        }
        
        for (int i = 1; i <= number; i++)
        {
            index = random.Next(1, allCards.Count);
            deck.Add(allCards[index]);
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
    
    public void PlayCard()
    {
        Debug.Log("Carte cliquée !");
    }
    void Start()
    {
        if (scene == "AgentsScene")
        {
            DrawCards(5);
            int x = -8;
            foreach (GameObject card in deck)
            {
                DisplayCard(card, x);
                x += 4;
                //card.GetComponent<Button>();
                //card.onClick.AddListener(PlayCard);
            }
            
        }
    }

    void Update()
    {
        
    }
}
