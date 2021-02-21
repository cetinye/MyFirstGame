using UnityEngine;
using TMPro;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    public TextMesh text_tap;

    private void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Spikes")
        {
            Debug.Log("We hit spike");
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }

        if (collisionInfo.collider.tag == "Finish")
        {
            Debug.Log("We finished !");
        }
    }
}
