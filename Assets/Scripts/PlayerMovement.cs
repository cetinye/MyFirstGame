using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float horizontalInput;
    public float turnSpeed = 50.0f;
    public float speed = 50.0f;
    public Rigidbody rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Constant speed
        transform.Translate(Vector3.forward * Time.deltaTime * speed);


        //Move horizontal
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput / 100);
        transform.Rotate(0, 0, 0);
        rigidbody.angularVelocity = new Vector3(0.0f, 0.0f, 0.0f);

        if(rigidbody.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
