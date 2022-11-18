using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movementSpeed = 5.0f;
    public float rotationSpeed = 200.0f;
    private Animator anim;
    public float x, y;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");

        transform.Rotate(0, x * Time.deltaTime * rotationSpeed, 0);
        transform.Translate(0, 0, y * Time.deltaTime * movementSpeed);
        // rb.AddForce(transform.forward * y * movementSpeed, ForceMode.Force);

        float rotationY = Input.GetAxis("Mouse X");

        transform.Rotate(new Vector3(0, rotationY * Time.deltaTime * rotationSpeed, 0));

        anim.SetFloat("VelX", x);
        anim.SetFloat("VelY", y);
    }
}