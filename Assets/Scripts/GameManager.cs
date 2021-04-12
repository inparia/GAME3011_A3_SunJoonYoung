using UnityEngine;
using UnityEngine.SceneManagement;

public enum GameLevel
{
	EASY,
	NORMAL,
	HARD
}
public class GameManager : MonoBehaviour {

	public static GameManager instance;


	public int score, lastScore;
	public float timer;
	public bool gameStarted = false;
	public GameLevel gameLevel;

	void Awake() {
		score = 0;
		if (instance == null) {
			DontDestroyOnLoad(gameObject);
			instance = GetComponent<GameManager>();
		} else {
			Destroy(gameObject);
		}
	}
    public void ResetGame()
    {
		gameStarted = false;
		score = 0;
		timer = 0;
	}
    void Update() {
		if (Input.GetKeyDown(KeyCode.Escape)) {
			ResetGame();
			SceneManager.LoadScene("Main");
		}

		if(gameStarted)
        {
			timer -= Time.deltaTime;
        }

		if(gameStarted && timer < 0)
        {
			lastScore = score;
			ResetGame();
			SceneManager.LoadScene("End");
        }
	}

}
