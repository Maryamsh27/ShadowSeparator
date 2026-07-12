using UnityEngine;
using UnityEngine.SceneManagement;

public class WinZone : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            string currentScene = SceneManager.GetActiveScene().name;

            if (currentScene == "Level1")
            {
                Debug.Log("Level Complete");
                SceneManager.LoadScene("Level2");
            }
            else if (currentScene == "Level2")
            {
                Debug.Log("Level Complete");
                SceneManager.LoadScene("Level3");
            }
        }
    }
}