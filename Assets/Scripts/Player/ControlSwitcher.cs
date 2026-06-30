using UnityEngine;

public class ControlSwitcher : MonoBehaviour
{
    public GameObject player;
    public GameObject shadow;

    private bool controllingShadow = false;

    private PlayerMovement playerMovement;
    private ShadowMovement shadowMovement;

    void Start()
    {
        playerMovement = player.GetComponent<PlayerMovement>();
        shadowMovement = shadow.GetComponent<ShadowMovement>();

        if (shadowMovement != null)
        {
            shadowMovement.enabled = false;
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            controllingShadow = !controllingShadow;

            if (controllingShadow)
            {
                if (playerMovement != null)
                    playerMovement.enabled = false;

                if (shadowMovement != null)
                    shadowMovement.enabled = true;

                Debug.Log("Shadow Control");
            }
            else
            {
                if (shadowMovement != null)
                    shadowMovement.enabled = false;

                if (playerMovement != null)
                    playerMovement.enabled = true;

                Debug.Log("Player Control");
            }
        }
    }
}