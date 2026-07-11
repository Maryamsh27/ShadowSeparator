using UnityEngine;

public class WinPortal : MonoBehaviour
{
    public GameObject winCanvas;

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Portal Triggered");

        if (other.CompareTag("Player"))
        {
            Debug.Log("YOU WIN!");

            if (winCanvas != null)
            {
                winCanvas.SetActive(true);
            }
        }
    }
}