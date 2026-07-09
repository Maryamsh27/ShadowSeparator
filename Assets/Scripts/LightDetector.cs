using UnityEngine;
using UnityEngine.SceneManagement;

public class LightDetector : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Shadow"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}