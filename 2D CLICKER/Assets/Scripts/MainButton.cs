using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MainButton : MonoBehaviour
{
    public GameObject textBox;

    public void ClickTheButton()
    {
        CookieNumber.CookieCount += 1;
    }


}
