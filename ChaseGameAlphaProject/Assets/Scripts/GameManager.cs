using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public Button restartButton;
    public GameObject Sphere;
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
        {
            // Check if the Sphere collided with the Player
            if (collision.gameObject == Player)
            {
                // Show the Game Over text
                restartButton.gameObject.SetActive(true);

                // Stop the game by setting the time scale to zero
                Time.timeScale = 0;
            }
        }

     public void RestartGame()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
}
