using UnityEngine;

public class DoorController : MonoBehaviour
{
    public GameObject door;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Shadow")
        {
            door.SetActive(false);
        }
    }
}