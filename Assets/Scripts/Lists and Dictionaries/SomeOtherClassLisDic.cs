using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomeOtherClassLisDic : MonoBehaviour
{
    void Start()
    {
        Dictionary<string,BadGuy> badguys = new Dictionary<string,BadGuy>();

        BadGuy bg1 = new BadGuy("harvey", 50);
        BadGuy bg2 = new BadGuy("Magneto", 100);

        badguys.Add("gangster", bg1);
        badguys.Add("mutant", bg2);

        BadGuy magneto = badguys["mutant"];

        BadGuy temp = null;

        if(badguys.TryGetValue("birds", out temp))
        {
            //sucess!
        }
        else
        {
            // failure
        }
    }
}
