using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManagerScript : MonoBehaviour
{
    public Text coinsleft;
    public Text winText;
    public Text loseText;
    private bool gameEnded = false;

    public int cur_coins = 0;

    public int max_coins = 0;

    public GameObject Door;

    void Start()
    {
        Door.SetActive(false);
        max_coins = cur_coins;
        UpdateUI();

    }

    void Update()
    {
        
    }

    public void UpdateUI()
    {
        if (cur_coins > 0)
        {
            coinsleft.text = "Coins Left : " + cur_coins.ToString("D3") + "/" + max_coins.ToString("D3");
        }
        else if (cur_coins == 0)
        {
            Door.SetActive(true);
        }
        void win()
        {
            winText.gameObject.SetActive(true);
            gameEnded = true;
        }

        void lose()
        {
            loseText.gameObject.SetActive(true);
            gameEnded = true;
        }
    }
}
