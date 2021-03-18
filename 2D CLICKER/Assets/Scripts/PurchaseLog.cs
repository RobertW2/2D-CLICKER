using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PurchaseLog : MonoBehaviour
{
    public GameObject autoCookie;
    public GlobalBaker globalBaker;
    public GameObject priceText;
    public Button baker;
    //public int tomPrice = 3;

    private AutoFollower autoFollower;

    public int cost1 = 3;
    public int increaseFollowerCount = 1;
    public string Name;

    private void Start()
    {
        autoFollower = autoCookie.GetComponent<AutoFollower>();
    }

    private void Update()
    {
        if (globalBaker.currentCash >= cost1)
        {
            baker.interactable = true;
        }
    }

    public void Upgrade()
    {
        if (globalBaker.currentCash >= cost1)
        {
            CookieNumber.CookieCount -= cost1;
            AutoFollower.FollowerIncrease += increaseFollowerCount;
            autoCookie.SetActive(true);

            cost1 *= 2;
            priceText.GetComponent<UnityEngine.UI.Text>().text = Name+ ": "  + cost1 +  "Followers";
        }
    }

}
