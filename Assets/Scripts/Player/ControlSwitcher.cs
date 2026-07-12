using UnityEngine;

public class ControlSwitcher : MonoBehaviour
{
    public GameObject player;
    public GameObject shadow;

    public AudioSource switchSound;

    private bool controllingShadow = false;

    private PlayerMovement playerMovement;
    private ShadowMovement shadowMovement;

    void Start()
    {
        if (player != null)
        {
            playerMovement = player.GetComponent<PlayerMovement>();
        }

        if (shadow != null)
        {
            shadowMovement = shadow.GetComponent<ShadowMovement>();
        }

        if (shadowMovement != null)
        {
            shadowMovement.enabled = false;
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (switchSound != null)
            {
                switchSound.Play();
            }

            controllingShadow = !controllingShadow;

            if (controllingShadow)
            {
                if (playerMovement != null)
                {
                    playerMovement.enabled = false;
                }

                if (shadowMovement != null)
                {
                    shadowMovement.enabled = true;
                }

                Debug.Log("Shadow Control");
            }
            else
            {
                if (shadowMovement != null)
                {
                    shadowMovement.enabled = false;
                }

                if (playerMovement != null)
                {
                    playerMovement.enabled = true;
                }

                Debug.Log("Player Control");
            }
        }
    }
}