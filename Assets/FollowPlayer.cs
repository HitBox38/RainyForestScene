using UnityEngine;

public class RainFollowPlayer : MonoBehaviour
{
    [SerializeField] private Transform playerTransform;
    [SerializeField] private Vector3 offset = new Vector3(0, 100, 0); // Default offset above player

    void Start()
    {
        // If player transform is not assigned in inspector, try to find it
        if (playerTransform == null)
        {
            GameObject player = GameObject.FindGameObjectWithTag("Player");
            if (player != null)
            {
                playerTransform = player.transform;
            }
            else
            {
                Debug.LogError("Player not found. Please assign the player transform in the inspector.");
            }
        }
    }

    void Update()
    {
        if (playerTransform != null)
        {
            // Move the entire particle system GameObject to follow the player
            transform.position = playerTransform.position + offset;
        }
    }
}
