using UnityEngine;

[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class ClipCamera : MonoBehaviour {
    
    public float minX = -10f;
    public float maxX = 10f;
    public float minY = -10f;
    public float maxY = 10f;

    private Camera cam;
    
    private void Awake() {
        cam = GetComponent<Camera>();
    }
    
    private void LateUpdate() {
        if (cam.orthographic) {
            float camHeight = cam.orthographicSize;
            float camWidth = cam.aspect * camHeight;

            float clampedX = Mathf.Clamp(transform.position.x, minX + camWidth, maxX - camWidth);
            float clampedY = Mathf.Clamp(transform.position.y, minY + camHeight, maxY - camHeight);

            transform.position = new Vector3(clampedX, clampedY, transform.position.z);
        }
    }

}
