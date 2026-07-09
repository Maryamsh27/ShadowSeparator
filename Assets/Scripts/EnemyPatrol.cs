using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    void Update()
    {
        transform.Translate(Vector2.right * 2f * Time.deltaTime);
    }
}