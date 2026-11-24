using UnityEngine;

public class Pickup : MonoBehaviour
{ 

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("something touched the coin");

        if (collision.CompareTag("Player"))
        {
            Debug.Log("Coin collected");

            Destroy(gameObject);
        }
    }
}
