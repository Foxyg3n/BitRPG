using UnityEngine;

public class Coin : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("Player")) {
            Collect();
        }
    }

    public void Collect() {
        Destroy(gameObject);
        GameManager.instance.coins++;
    }

}
