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
    
    void Start()
    {
        gameOverText.gameObject.SetActive(false);
    }

    
    void Update()
    {
        Sphere.transform.position = Vector3.MoveTowards(Sphere.transform.position, Player.transform.position, speed);
    }

    void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject == Player)
        {
            
            gameOverText.gameObject.SetActive(true);

            
            Time.timeScale = 0;
        }
    }




}
