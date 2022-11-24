using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] Animator anime;
    [SerializeField] float moveSpeed = 5.0f;
    [SerializeField] Transform orienatation;
    float horizontalInput, verticalInput;
    Vector3 moveDirection;
    Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
    }
    private void Update()
    {
        KeyInputs();
    }

    private void FixedUpdate()
    {
        MovePlayer();
    }

    void KeyInputs()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
    }

    void MovePlayer()
    {
        if (horizontalInput != 0 || verticalInput != 0)
        {
            anime.SetBool("isWalk", true);
        }
        else
        {
            anime.SetBool("isWalk", false);
        }
        moveDirection = orienatation.forward * verticalInput + orienatation.right * horizontalInput;
        transform.Translate(moveDirection.normalized * Time.deltaTime * moveSpeed);
    }
}
