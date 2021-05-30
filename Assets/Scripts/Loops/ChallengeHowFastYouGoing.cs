using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChallengeHowFastYouGoing : MonoBehaviour
{
    // Create a program where you increment the value of speed by 5 every second.
    // When speed is greater than MaxSpeed, stop incrementing (random number between
    // 60 and 120).  Hint: use a couroutine.

    public int maxSpeed;
    public int speed;


    // Start is called before the first frame update
    void Start()
    {
        maxSpeed = Random.Range(60, 120);
        StartCoroutine(MaxSpeedReached());
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    IEnumerator MaxSpeedReached()
    {
        while (speed < maxSpeed)
        {
            speed += 5;
            yield return new WaitForSeconds(0.5f);
        }
        speed = maxSpeed;
        Debug.Log("You have reached and are being held back at your max speed!");

        // if you wanted to use a DO - WHILE loop
        //
        //  do
        //  {
        //      speed += 5;
        //      yield return new WaitForSeconds(0.5f);
        //
        //  } while (speed < maxSpeed);
        //

        // Example of the solution provided by mentor:
        //
        //  while (true)
        //  {
        //      yield retuen new WaitForSeconds(0.5f);
        //      speed += 5;
        //
        //      if (speed > maxSpeed)
        //      {
        //          break;
        //      }
        //  }
        //

    }

}
