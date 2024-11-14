using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine;



public class Chase : MonoBehaviour
{
    public GameObject Sphere;
    public GameObject Player;
    public float speed;
    public TMP_Text gameOverText;
    // Start is called before the first frame update
    void Start()
    {
        gameOverText.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Sphere.transform.position = Vector3.MoveTowards(Sphere.transform.position, Player.transform.position, speed);
    }

    void OnCollisionEnter(Collision collision)
    {
        // Check if the Sphere collided with the Player
        if (collision.gameObject == Player)
        {
            // Show the Game Over text
            gameOverText.gameObject.SetActive(true);

            // Stop the game by setting the time scale to zero
            Time.timeScale = 0;
        }
    }




}
