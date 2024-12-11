using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
   Rigidbody rb;

   public float baseSpeed = 5f;
   private float currentSpeed;

    public bool hasPowerup = false;
    private bool canJump = true;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        currentSpeed = baseSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && canJump)
        {
            rb.AddForce(Vector3.up * 400, ForceMode.Impulse);
            canJump = false;
            StartCoroutine(JumpCooldown());
        }

        transform.Translate(Vector3.forward * Time.deltaTime * -currentSpeed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("PowerUp"))
        {
            hasPowerup = true;
            currentSpeed = baseSpeed * 1.5f;
            Destroy(other.gameObject);
            StartCoroutine(PowerupCountdownRoutine());
        }
    }

    IEnumerator PowerupCountdownRoutine()
    {
        yield return new WaitForSeconds(5);
        hasPowerup = false;
        currentSpeed = baseSpeed;
    }

    IEnumerator JumpCooldown()
    {
        yield return new WaitForSeconds(0.5f);
        canJump = true;
    }
}
