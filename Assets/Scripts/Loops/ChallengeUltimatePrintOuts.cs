using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChallengeUltimatePrintOuts : MonoBehaviour
{
    // Create a program that prints out 0-10, then prints out even numbers from 11-20,
    // and only odd numbers from 21-30.  Hint use modulus operator.
    public int myNumber;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 30; i++)
        {
            if (i <= 10)
            {
                Debug.Log(i);
            }
            else if (i >= 10 && i <= 20)
            {
                if (i % 2 == 0)
                {
                    Debug.Log(i);
                }
            }
            else if (i > 20)
            {
                if (i % 2 == 1)
                {
                    Debug.Log(i);
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
