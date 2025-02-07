using UnityEngine;

public class Sprayed : MonoBehaviour
{
    private void OnParticleCollision(GameObject other)
    {
        Debug.Log("Particle collision detected with: " + other.name);

        if (other.CompareTag("Water"))
        {
            Debug.Log("Water particles are hitting the collider.");
        }
        else
        {
            Debug.Log("Non-water particles detected.");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger entered by: " + other.name);
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("Object is staying inside the trigger: " + other.name);
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Object exited the trigger: " + other.name);
    }
}
