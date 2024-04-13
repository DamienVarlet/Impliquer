using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cards : MonoBehaviour
{
    public static Cards Instance { get; private set; }

    private void Awake() 
    { 
        // If there is an instance, and it's not me, delete myself.
        
        if (Instance != null && Instance != this) 
        { 
            Destroy(this); 
        } 
        else 
        { 
            Instance = this; 
        } 
    }
    
    //bool isCardVisible = true;
    //public Button button;
    /*
    public void ToggleCard()
    {
        isCardVisible = !isCardVisible;
        //Declaration_de_guerre_5p.GetComponent<Renderer>().enabled = isCardVisible;
    }
    
    public void OnButtonClick()
    {
        Debug.Log("Carte cliquée !");
    }
    */
    // Start is called before the first frame update
    void Start()
    {
        //button = GameObject.Find("Button2").GetComponent<Button>();
        //button.onClick.AddListener(OnButtonClick);
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if(Input.GetMouseButtonDown(0))
        {
            ToggleCard();
        }
        */
    }
}
