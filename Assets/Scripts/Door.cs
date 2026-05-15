using UnityEngine;

public class Door : MonoBehaviour {

    private new Animation animation;
    
    private bool isOpen;

    private void Awake() {
        animation = GetComponent<Animation>();
    }

    public void Open() {
        if(isOpen) return; 
        animation.Play("Open");
        isOpen = true;
    }

    public void Close() {
        if(!isOpen) return;
        animation.Play("Close");
        isOpen = false;
    }

    public void Toggle() {
        if(isOpen) Close();
        else Open();
        isOpen = !isOpen;
    }
    
}
