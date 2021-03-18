using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MainButton : MonoBehaviour
{
    public GameObject textBox;

    public void ClickTheButton()
    {
        // Adds Folloers/cookie to the stash every click
        CookieNumber.CookieCount += 1;
    }


}
