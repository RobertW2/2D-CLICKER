using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoFollower : MonoBehaviour
{

    public bool CreatingFollowers = false;
    public static int FollowerIncrease = 0;
    private int InternalIncrease = 0;



    // Update is called once per frame
    void Update()
    {
        InternalIncrease = FollowerIncrease;
        if(CreatingFollowers == false)
        {
            CreatingFollowers = true;
            StartCoroutine(CreateTheFollowers());
        }
    }

    IEnumerator CreateTheFollowers()
    {
        yield return new WaitForSeconds(1);
        CookieNumber.CookieCount += InternalIncrease;
        CreatingFollowers = false;
           
    }
}
