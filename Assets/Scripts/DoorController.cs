using UnityEngine;

public class ButtonTrigger : MonoBehaviour
{
    public GameObject door;
    public GameObject portal;

    private bool activated = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (activated) return;

        if (other.CompareTag("Shadow"))
        {
            activated = true;

            door.SetActive(false);
            portal.SetActive(true);

            Debug.Log("Portal Activated!");
        }
    }
}