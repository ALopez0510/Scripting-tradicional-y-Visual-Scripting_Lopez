using UnityEngine;

public class Coin : MonoBehaviour
{
    // Se ejecuta automáticamente cuando algo atraviesa el Trigger
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Verifica si quien tocó la moneda tiene el Tag "Player"
        if (collision.CompareTag("Player"))
        {
            // Destruye la moneda (la recoge)
            Destroy(gameObject);
        }
    }
}