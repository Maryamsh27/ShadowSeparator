using UnityEngine;

public class ButtonTrigger : MonoBehaviour
{
    public GameObject door;

    private bool activated = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (activated) return;

        if (other.CompareTag("Shadow"))
        {
            activated = true;

            door.SetActive(false);

            Debug.Log("Door Opened!");
        }
    }
}