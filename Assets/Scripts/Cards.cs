using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cards : MonoBehaviour
{
    public GameObject Card;
    bool isCardVisible = true;
    public void ToggleCard()
    {
        isCardVisible = !isCardVisible;
        Card.GetComponent<Renderer>().enabled = isCardVisible;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            ToggleCard();
        }
    }
}
