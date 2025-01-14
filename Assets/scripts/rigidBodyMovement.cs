using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]         //Tell Unity to add theses components to the gameobject this code is attached to.
[RequireComponent(typeof(BoxCollider2D))]       //We will still need to tweak some of the settings.
public class RigidbodyMovement : MonoBehaviour
{
    Rigidbody2D rb2d;
    public float moveSpeed = 5f;
    public float zoom;
    public float zoomMultiplier = 4f;
    public float minZoom = 5f;
    public float maxZoom = 6f;
    public float velocity = 0f;
    public float smoothTime = 0.25f;

    [SerializeField] private Camera cam;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        zoom = cam.orthographicSize;
    }

    void Update()
    {
        float scroll = moveSpeed;
        zoom -= scroll * zoomMultiplier;
        zoom = Mathf.Clamp(zoom, minZoom, maxZoom);
        cam.orthographicSize = Mathf.SmoothDamp(cam.orthographicSize, zoom, ref velocity, smoothTime);

        float moveInputX = Input.GetAxisRaw("Horizontal"); // For horizontal movement (left/right)
        float moveInputY = Input.GetAxisRaw("Vertical");   // For vertical movement (up/down)

        // Normalise the vector so that we don't move faster when moving diagonally.
        Vector2 moveDirection = new Vector2(moveInputX, moveInputY);
        moveDirection.Normalize();

        // Assign velocity directly to the Rigidbody
        rb2d.velocity = moveDirection * moveSpeed;

              if (Input.GetButton("Fire3"))
        {
            moveSpeed = 10f;
            minZoom = 3f;
        }

            if (Input.GetButtonUp("Fire3"))
        {
            moveSpeed = 5f;
            minZoom = 5f;
        }
    }
}