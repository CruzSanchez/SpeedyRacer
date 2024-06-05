using UnityEngine;

public class Booster : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Collision");

        Rigidbody2D rb = collision.gameObject.GetComponent<Rigidbody2D>();
        Debug.Log("Got RB");

        rb.AddForce(new Vector3(5f, 0, 0), ForceMode2D.Impulse);
        Debug.Log("Added Force!");
    }
}
