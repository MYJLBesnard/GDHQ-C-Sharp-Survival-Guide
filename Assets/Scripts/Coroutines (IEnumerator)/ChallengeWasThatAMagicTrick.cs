using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChallengeWasThatAMagicTrick : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
<<<<<<< Updated upstream
        
=======
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
>>>>>>> Stashed changes
    }
}
