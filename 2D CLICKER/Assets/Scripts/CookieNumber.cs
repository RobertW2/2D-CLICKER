using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CookieNumber : MonoBehaviour
{


    public static int CookieCount;
    public GameObject CookieDisplay;
    public int InternalCookie;

    // Update is called once per frame
    void Update()
    {
        InternalCookie = CookieCount;
        CookieDisplay.GetComponent<TMPro.TextMeshProUGUI>().text = "Followers: " + InternalCookie;
    }
}
