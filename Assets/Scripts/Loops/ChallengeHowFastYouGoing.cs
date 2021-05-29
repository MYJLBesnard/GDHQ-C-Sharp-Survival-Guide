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
        while (speed != maxSpeed)
        {
            speed++;
            yield return new WaitForSeconds(1.0f);
        }
    }

}
