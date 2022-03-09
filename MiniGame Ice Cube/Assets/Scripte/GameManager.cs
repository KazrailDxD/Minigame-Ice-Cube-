using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UIElements;

public class GameManager : MonoBehaviour
{

    [SerializeField] GameObject player = null;
    [SerializeField] GameObject gameOverPanel = null;
    [SerializeField] IceHazardSpawner spawner = null;
    bool gameOver = false;
    float timeSurvived = 0.0f;

    [SerializeField] TextMeshProUGUI timeSurvivedText = null;
    [SerializeField] AudioClip[] backgroundMusikClips = null;
    [SerializeField] GameObject pausePanel = null;

    public static bool gameIsPaused { get; private set; } = false;

    private void Awake()
    {
        gameIsPaused = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        AudioSource audioSource = GetComponent<AudioSource>();
        audioSource.clip = backgroundMusikClips[Random.Range(0, backgroundMusikClips.Length)];
        audioSource.Play();

    }

    // Update is called once per frame
    void Update()
    {
        if(player == null && !gameOver) 
        {
            gameOver = true;
            gameOverPanel.SetActive(true);
            spawner.StopAllCoroutines();
            timeSurvivedText.text = string.Format("Du hast {0} sekunden durchgehalten!", timeSurvived.ToString("0.00"));
        }

        if (!gameOver)
        {
            timeSurvived += Time.deltaTime;
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            TogglePauseState();
        }
    }

    public void TogglePauseState()
    {

        gameIsPaused = !gameIsPaused;

        if (gameIsPaused)
        {
            Time.timeScale = 0.0f;
            pausePanel.SetActive(true);
        }
        else 
        {
            Time.timeScale = 1.0f;
            pausePanel.SetActive(false);
        }
    }
}
