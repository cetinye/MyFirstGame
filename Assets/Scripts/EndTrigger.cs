using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager GameManager;

    private void OnTriggerEnter(Collider other)
    {
        FindObjectOfType<GameManager>().CompleteLevel();
    }
}
