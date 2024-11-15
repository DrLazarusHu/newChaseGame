using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FinishText : MonoBehaviour
{
    public GameObject Finish;  // Reference to the Finish object
    public TextMeshProUGUI winText;  // Reference to the TextMeshPro UI element

    void OnCollisionEnter(Collision collision)
    {
        // Check if the Player collided with the Finish block
        if (collision.gameObject.CompareTag("Player"))
        {
            winText.gameObject.SetActive(true);
            Time.timeScale = 0;
        }
    }

    // Ensure the text is disabled at the start
    void Start()
    {
        winText.gameObject.SetActive(false);
    }
}
