using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class monedas : MonoBehaviour
{
    public Text Coins;
    public int coins;
    // Start is called before the first frame update
    void Start()
    {
        LoadCoins();
    }

    void LoadCoins()
    {
        Coins.text = "Coins: " + coins.ToString();
    }
}
