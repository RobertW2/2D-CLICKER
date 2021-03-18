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
    
    public Button button;
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

        // If The current total is more than or equal to the cost of the upgrade, then allow to purchase.
        if (globalBaker.currentCash >= cost1)
        {
            // Make button interactible
            button.interactable = true;
        }
    }

    public void Upgrade()
    {
        //If The current total is more than or equal to the cost of the upgrade, then allow to purchase.

        if (globalBaker.currentCash >= cost1)
        {
            // Minus the cost from the total amount.
            CookieNumber.CookieCount -= cost1;
            AutoFollower.FollowerIncrease += increaseFollowerCount;
            autoCookie.SetActive(true);

            // Double the price once bought.
            cost1 *= 2;
            // Update the Text of the upgrade button.
            priceText.GetComponent<UnityEngine.UI.Text>().text = Name+ ": "  + cost1 +  " Followers";
           
        }
    }


}
