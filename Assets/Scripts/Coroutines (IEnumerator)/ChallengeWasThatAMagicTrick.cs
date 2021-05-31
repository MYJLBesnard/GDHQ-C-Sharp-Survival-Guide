using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChallengeWasThatAMagicTrick : MonoBehaviour
{
    // Create a program that turns the cube invisible for 5 seconds and then re-appears.
    // This happens when the "i" key is pressed.
    // Make sure to not allow the "i" key to be pressed if the cube is already hidden.

    public GameObject cube;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("The program has started");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            Debug.Log("The 'i' key has been pressed.");
            GetComponent<MeshRenderer>().enabled = false;
            Debug.Log("The cube has vanished!");

            StartCoroutine(HideTheCube());
        }
    }

    IEnumerator HideTheCube()
    {
       
       

        
        yield return new WaitForSeconds(5.0f);
        Debug.Log("The wait is over...");
        GetComponent<MeshRenderer>().enabled = true;
    }
}
