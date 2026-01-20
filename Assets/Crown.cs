using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crown : MonoBehaviour
{
   public GameObject explosion;

    // Add a message to detect when this GameObject collides with something
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            Score score = FindObjectOfType<Score>();
            if (score)
            {
                score.EndLevel();
            }

            if (explosion)
            {
                Instantiate(explosion, transform.position, Quaternion.identity);
                Destroy(gameObject);
                print("You win!");
            }
        }

    }
    // Inside that message find out if the object collided with is part of the ground.
    // Hint: Find out if an object is part of the ground using gameObject.CompareTag()
    // If the crown is on the ground, print "You Win!" to the console.
}
