using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    float moveSpeed;
    [SerializeField]
    float steerSpeed;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        float turnAxis = Input.GetAxis("Horizontal");
        float moveAxis = Input.GetAxis("Vertical");

        float calculatedSteering = (-turnAxis * steerSpeed) * Time.deltaTime;
        float calculatedMovement = (moveAxis * moveSpeed) * Time.deltaTime;

        transform.Rotate(0, 0, calculatedSteering);
        transform.Translate(0, calculatedMovement, 0);
    }
}
