using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Notes : MonoBehaviour
{
    public string myName = "Michel";
    public int apples; // set to zero by default
    public int oranges;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(AddApplesRoutine());

        StartCoroutine(LoopRoutine());
        
    }

    IEnumerator LoopRoutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(1.0f);
            Debug.Log("Spawn a enemy ship!");
        }
    }

    IEnumerator AddApplesRoutine()
    {
        for (int i=0; i < 20; i++)
        {
            apples++; // increments apples by 1 on every loop, verify this by looking
                      // at the apples variable in the inspector
            yield return new WaitForSeconds(0.5f); // waits for 0.5 second before continuing
        }
    }
}

/*
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

        // FOR-EACH loops are unique to C# and only work with Collections and Arrays

        // example of a DO Loop
        // DO {something in code, index incrementer} WHILE (condition);
        // if we don't increment, we run the risk of gettin stuck in an infinite loop
        // since (if qty of oranges had been less than 7), it would never be increased
        // therefore never meet the condition to exit the DO loop.
        //
        // No matter what, the code will run at least once since it runs before
        // we check against the condition.  Let's say we already had 8 oranges to begin
        // with, the code would run, an orange would be added, we would print out 9 oranges,
        // then the condition would be checked (oranges < 7), and since the condition is
        // met, we would end that particular loop.

        do
        {
            Debug.Log(oranges);
            oranges++;
        } while (oranges < 7);

// example of a WHILE Loop

WHILE (condition)
{
Run Code
}

// best to use them inside a Coroutine so it's possible to break out or stop the program.
// dangerous to have them outside of a Coroutine, since it could crash the program unless
// you include a condition that can be met to exit the loop (such as an incrementer).
// example of a WHILE loop using a Coroutine:

void Start()
    {
        StartCoroutine(LoopRoutine());   
    }

    IEnumerator LoopRoutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(1.0f);
            Debug.Log("Spawn a enemy ship!");
        }
    }

*/
