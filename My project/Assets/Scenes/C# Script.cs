using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string heroName = "Goku";
        double heroHeight = 1.85;
        int heroAge = 101;
        string heroSuperPower = "Lazer";


        string villainName = "Knight";
        double villainHeight = 2.50;
        int villainAge = 200;
        string villainSuperPower = "Super Strenght";


        System.Console.WriteLine("I am the Hero {0}, my hight is {1}, and I am {2} years old, my super power is to shoot {3}", heroName, heroHeight, heroAge, heroSuperPower);
        System.Console.WriteLine($"I am the villin may name is {villainName},my hight is {villainHeight}, and my age is {villainAge}, my super power is {villainSuperPower}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
