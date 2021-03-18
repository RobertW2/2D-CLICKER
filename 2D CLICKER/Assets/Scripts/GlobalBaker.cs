using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalBaker : MonoBehaviour
{

    public Button baker;


    public int currentCash;

    public PurchaseLog purchaseLog;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        // Global stash of cookies/followers
        currentCash = CookieNumber.CookieCount;
       



 
   
    }

   


}
