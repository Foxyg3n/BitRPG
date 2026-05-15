using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float speed = 0.07f;
    public float sprintSpeed = 0.1f;
    
    private Animator animator;
    private new Rigidbody2D rigidbody;
    // [SerializeField] private SpeechBubble speechBubble;
    [SerializeField] private Door testDoor;
    
    private Vector2 movementInput;
    private Vector2 lastDirection = Vector2.down;
    private bool isSprinting;
    
    private void Awake() {
        animator = GetComponent<Animator>();
        rigidbody = GetComponent<Rigidbody2D>();
    }
    
    private void Update() {
        float x  = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        isSprinting = Input.GetKey(KeyCode.LeftShift);

        // if(Input.GetKeyDown(KeyCode.E)) {
        //     speechBubble.FadeIn();
        // } else if(Input.GetKeyDown(KeyCode.Q)) {
        //     speechBubble.FadeOut();
        // }
        
        movementInput = new Vector3(x, y);
        if (movementInput != Vector2.zero) {
            lastDirection = movementInput.x != 0 ? new Vector2(movementInput.x, 0) : new Vector2(0, movementInput.y);
        }
        UpdateAnimation();

        if(Input.GetKeyDown(KeyCode.E)) {
            testDoor.Open();
        }
    }

    private void FixedUpdate() {
        if (movementInput != Vector2.zero) {
            float chosenSpeed = isSprinting ? sprintSpeed : speed;
            rigidbody.MovePosition(rigidbody.position + movementInput.normalized * chosenSpeed);
        }
    }

    private void UpdateAnimation() {
        animator.SetFloat("LookX", lastDirection.x);
        animator.SetFloat("LookY", lastDirection.y);
        animator.SetBool("IsMoving", movementInput != Vector2.zero);
        
        // Debug.Log($"Animation Update - LookX: {lastDirection.x}, LookY: {lastDirection.y}, IsMoving: {movementInput != Vector2.zero}");
    }
    
}
