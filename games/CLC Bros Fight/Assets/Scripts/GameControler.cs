using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GameControler : MonoBehaviour
{
    public Color[] playerColors;
    public List<PlayerController> players = new List<PlayerController>();

    public Transform[] spawnPoints;


    [Header("Componets")]
    public GameObject deathEffectPrefab;

    public static GameControler instance;

    private void Awake()
    {
        instance = this;
    }


    public void OnPlayerJoined(PlayerInput playerInput)
    {
        // set player color
        playerInput.GetComponentInChildren<SpriteRenderer>().color = playerColors[players.Count];
        players.Add(playerInput.GetComponent<PlayerController>());
        playerInput.transform.position = spawnPoints[Random.Range(0, spawnPoints.Length)].position;

        //Tag thing, don't worry about it
        playerInput.GetComponentInChildren<TagStuff>().is_it = players.Count == 1;
    }

    public void OnPlayerDeath(PlayerController player, PlayerController attacker)
    {
        // Spawn death effect
        
        // Increase the player score for the attacker
        if (attacker != null)
        {
            attacker.score++;
        }
        else
        {
            player.score--;
            if (player.score < 0)
            {
                player.score = 0;
            }
        }
        // Respawn player
        player.transform.position = spawnPoints[Random.Range(0, spawnPoints.Length)].position;
        player.rig.velocity = new Vector2(0, 0);
        player.curHp = player.maxHp;
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
