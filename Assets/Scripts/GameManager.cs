using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public static GameManager instance;

    [Header("References")]
    public TMP_Text coinText;
    
    [Header("Variables")]
    public float coins;

    private void Awake() {
        instance = this;
    }

    private void Update() {
        coinText.text = $"x{coins}";
    }

}
