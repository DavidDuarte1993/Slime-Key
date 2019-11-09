using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopManager : MonoBehaviour
{
    private string dontHaveMoney;
    public int price;
    public int numItems;
    public GameObject soldout;
    public GameObject noMoneyPanel;

    private void Start()
    {
        soldout.SetActive(false);
        noMoneyPanel.SetActive(false);
    }
    public void Buy()
    {
        if (numItems > 0)
        {
            if (MoneyManager.instance.currentCoin >= price)
            {
                MoneyManager.instance.currentCoin -= price;
                numItems--;
                MoneyManager.instance.UpdateUI();
            }
            else
            {
                noMoneyPanel.SetActive(true);
            }
        }
        else
        {
            soldout.SetActive(true);
        }
    }
}

