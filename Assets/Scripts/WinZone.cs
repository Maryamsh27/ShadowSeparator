using UnityEngine;
using UnityEngine.SceneManagement;

public class WinZone : MonoBehaviour
{
    public GameObject winCanvas;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            string currentScene = SceneManager.GetActiveScene().name;

            if (currentScene == "Level1")
            {
                SceneManager.LoadScene("Level2");
            }
            else if (currentScene == "Level2")
            {
                SceneManager.LoadScene("Level3");
            }
            else if (currentScene == "Level3")
            {
                if (winCanvas != null)
                {
                    winCanvas.SetActive(true);
                }
            }
        }
    }
}