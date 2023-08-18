using UnityEngine;

public class GameState : MonoBehaviour {
    public bool isGameOver;

    public void GameOver() {
        isGameOver = true;
        //call a UI class and enable the game over screen
    }
}

public class Player : MonoBehaviour {

    [SerializeField] private GameState gameState;

    void Update() {
        if (Input.GetKeyDown(KeyCode.Space))
            gameState.isGameOver = true;

        if (gameState.isGameOver) {
            gameState.GameOver();
            Destroy(this);
        }
    }
}