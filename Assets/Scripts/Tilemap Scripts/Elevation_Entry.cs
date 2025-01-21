using UnityEngine;

public class Elevation_Entry : MonoBehaviour
{
    public Collider2D[] mountainColliders;
    public Collider2D[] boundaryColliders;

private void OnTriggerEnter2D(Collider2D collision) 
    {
        Debug.Log("Triggered by: " + collision.gameObject.name);
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Player entered the trigger area.");

            foreach (Collider2D mountain in mountainColliders)
            {
                Debug.Log("Disabling: " + mountain.gameObject.name);
                mountain.enabled = false;
            }  
            foreach (Collider2D boundary in boundaryColliders)
            {
                Debug.Log("Enabling: " + boundary.gameObject.name);
                boundary.enabled = true;
            }  

            collision.gameObject.GetComponent<SpriteRenderer>().sortingOrder = 15;
            Debug.Log("Sorting order changed to 15.");
        }
    }
}
