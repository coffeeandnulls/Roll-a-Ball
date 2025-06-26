using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameManagerScript : MonoBehaviour
{
    public Text scoreText;
    public int Score=0;
    AudioSource audioSource;
    public AudioClip pickSound;
    public Text endGameText;
    bool gameEnded = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        audioSource = GetComponent<AudioSource>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if (gameEnded && Input.GetKeyDown(KeyCode.R))
        {
            Debug.Log("pressed R");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    public void addScore()
    {
        Score++;
        scoreText.text = "Score: " + Score.ToString();
        audioSource.PlayOneShot(pickSound);
        
        if(Score==10)
        {
            endGameText.enabled = true;
            gameEnded = true;
        }

    }
    
    
    
}
