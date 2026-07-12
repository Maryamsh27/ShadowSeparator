using UnityEngine;

public class WinPortal : MonoBehaviour
{
    public GameObject winCanvas;
    public AudioSource winSound;

    private bool won = false;

    private void Start()
    {
        if (winCanvas != null)
        {
            winCanvas.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (won) return;

        if (other.CompareTag("Player"))
        {
            won = true;

            Debug.Log("YOU WIN!");

            if (winCanvas != null)
            {
                winCanvas.SetActive(true);
            }

            GameObject music = GameObject.Find("AudioManager");

            if (music != null)
            {
                AudioSource bgMusic = music.GetComponent<AudioSource>();

                if (bgMusic != null)
                {
                    bgMusic.Stop();
                }
            }

            if (winSound != null)
            {
                winSound.Play();
            }

            Invoke("StopGame", 1f);
        }
    }

    private void StopGame()
    {
        Time.timeScale = 0f;
    }
}