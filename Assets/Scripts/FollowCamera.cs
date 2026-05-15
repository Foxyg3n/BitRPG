using UnityEngine;

public class FollowCamera : MonoBehaviour {
    
    public Transform target;
    public float smoothSpeed = 0.125f;
    public Vector2 offset;
    
    private bool isTargetSet;
    
    private void Start() {
        if (target == null) {
            Debug.LogWarning("FollowCamera: No target set. Please assign a target in the inspector.");
        } else {
            isTargetSet = true;
        }
    }
    
    private void FixedUpdate() {
        if (isTargetSet) {
            Vector2 desiredPosition = target.position + (Vector3) offset;
            Vector2 smoothedPosition = Vector2.Lerp(transform.position, desiredPosition, smoothSpeed);
            transform.position = new Vector3(smoothedPosition.x, smoothedPosition.y, transform.position.z);
        }
    }
    
}
