using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Notes : MonoBehaviour
{
    public string myName = "Michel";

    // Start is called before the first frame update
    void Start()
    {
        // basic syntax. Set your index variable i to zero, that's it's starting value.
        // you then check to see if i is less than 5, if "yes", you print "myName"
        // then add 1 to the index variable (i++).  You check again the value of i to see
        // if it's less than 5 and repeat the process until i = 5.  Once i = 5, you are done
        // with the loop, exit it, and print "myName Loop has finished!".

        for (int i = 0; i < 5; i++)
        {
            Debug.Log(myName);
        }

        Debug.Log("myName Loop has finished");

        // syntax for counting down.  Index set to 5, decrease by 1 until zero is reached.
        // print the value of the index instead of myName.

        for (int i = 5; i > 0; i--)
        {
            Debug.Log(i);
        }

        for (int i = 0; i <= 13; i++)
        {
            // print only even numbers, use the modulus to divide by 2 and check
            // for remainders.  If no remainder, then i is an even number, print i
            if (i % 2 == 0)
            {
                Debug.Log(i);
            }
        }

        for (int i = 0; i <= 13; i++)
        {
            // print only odd numbers, use the modulus to divide by 2 and check
            // for remainders.  If remainder = 1, then i is an odd number, print i
            if (i % 2 == 1)
            {
                Debug.Log(i);
            }
        }

        for (int i = 0; i < 20; i++)
        {
            // print only if i = 7
            if (i == 7)
            {
                Debug.Log("i is equal to " + i);
            }
        }

        // example of a breakout
        for (int i = 0; i < 20; i++)
        {
            Debug.Log(i);
            // once you reach 15, break out of the loop
            if (i == 15)
            {
                break;
            }
        }
        Debug.Log("The loop has finished upon reching 15.");


    }
}
