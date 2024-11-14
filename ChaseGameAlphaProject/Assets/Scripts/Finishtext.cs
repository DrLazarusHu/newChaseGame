using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Finishtext : MonoBehaviour
{

    public GameObject Finish;
    public GameObject Player;
    public TextMeshProUGUI winText;


    void OnCollisionEnter(Collision collision)
        {
            // Check if the Sphere collided with the Player
            if (collision.gameObject == Finish)
            {
                // Show the Game Over text
                winText.gameObject.SetActive(true);

                // Stop the game by setting the time scale to zero
                Time.timeScale = 0;
            }
        }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
