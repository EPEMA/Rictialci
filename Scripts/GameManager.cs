using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour{

        public float slowness = 10f;

        private ScoreManager theScoreManager;

        void Start()
        {
            theScoreManager = FindObjectOfType<ScoreManager> ();
        }


        //restart Level
    	public void EndGame ()
		{
            theScoreManager.scoreIncreasing = false;
			StartCoroutine(RestartLevel());
		}

        //Function for EndGame
        IEnumerator RestartLevel ()
        {
            Time.timeScale = 1f/ slowness;
            Time.fixedDeltaTime = Time.fixedDeltaTime / slowness;

            yield return new WaitForSeconds(1f / slowness);

            Time.timeScale = 1f;
            Time.fixedDeltaTime = Time.fixedDeltaTime * slowness;

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            
            theScoreManager.scoreIncreasing = true;
        }

    //Next Scene
    public void NextScene ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    
    //Retry Level
    public void Retry ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + -1);
    }

    //goes to the Menu
    public void Menu ()
    {
       SceneManager.LoadScene("Menu");
    }

    public void Quit ()
    {
        SceneManager.LoadScene("Quit");
    }

    public void Credits ()
    {
        SceneManager.LoadScene("Credits");
    }
}
