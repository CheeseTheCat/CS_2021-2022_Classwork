using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControler : MonoBehaviour
{
    private int totalPoints;
    [SerializeField]
    private int waveCount;
    [SerializeField]
    private float levelTime;
    [SerializeField]
    private TMPro.TextMeshProUGUI gameMenuText;
    public string nextScene;
    public float roundLength;


    [SerializeField]
    private SpawnerScript spawner;
    [SerializeField]
    private Bunkers bunkers;
    [SerializeField]
    private Transform gameMenu;

    private bool isRoundOver = true;


    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;

        spawner.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        levelTime -= Time.deltaTime;

        if (levelTime<=0 && !isRoundOver)
        {
            //end round
            completeRound();
        }
    }

    void completeRound()
    {
        isRoundOver = true;
        totalPoints += bunkers.baseCount * 100;
        if (bunkers.baseCount == 5)
        {
            totalPoints += 1000;
        }
        spawner.Stop();
        gameMenu.gameObject.SetActive(true);
        gameMenuText.text = string.Format("{0} bunkers remaining\n{1} total points", bunkers.baseCount, totalPoints);

        // Freeze every physic
        Debug.Log("Froze every physic we could find");
        Time.timeScale = 0;

        waveCount++;

        
    }

    public void startNextRound()
    {
        isRoundOver = false;
        Time.timeScale = 1;
        StartCoroutine(spawner.startSpawning());
        gameMenu.gameObject.SetActive(false);

        levelTime = roundLength;
        spawner.maxTime /= 1.1f;
        spawner.minTime /= 1.1f;

        if (waveCount > 10)
        {
            SceneManager.LoadScene(nextScene);
        }
        
    }


}
