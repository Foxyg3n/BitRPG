using UnityEngine;

public class SpeechBubble : MonoBehaviour {
    
    private new Animation animation;
    
    private void Awake() {
        animation = GetComponent<Animation>();
    }

    public void FadeIn() {
        animation.Play("FadeIn");
    }
    
    public void FadeOut() {
        animation.Play("FadeOut");
    }
    
}
