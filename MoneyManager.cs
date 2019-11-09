using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyManager : MonoBehaviour
{
    public Text moneyText;
    public int currentCoin;
    public static MoneyManager instance;
    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        if (PlayerPrefs.HasKey("CurrentMoney"))
        {
            currentCoin = PlayerPrefs.GetInt("CurrentMoney");
        }
        else
        {
            currentCoin = 0;
            PlayerPrefs.SetInt("CurrentMoney", 0);
        }
        UpdateUI();
    }

    public void UpdateUI()
    {
        moneyText.text = "" + currentCoin;
    }

    public void AddMoney(int coinToAdd)
    {
        currentCoin += coinToAdd;
        PlayerPrefs.SetInt("CurrentMoney", currentCoin);
        moneyText.text = "" + currentCoin;
    }
}
