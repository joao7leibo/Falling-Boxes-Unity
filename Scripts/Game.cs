using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Gamemanager : MonoBehaviour
{
    public GameObject block;
    public float maxX;
    public Transform spawnPoint;
    public float spawnRate;

    bool gameStarted = false;

    public GameObject tapText;
    public TextMeshProUGUI scoreText;


    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0) && !gameStarted  )
        {
            StartSpawning();

            gameStarted = true;
            tapText.SetActive(false);

        }
        
    }

    private void StartSpawning()
    {
        InvokeRepeating("SpawnBlock", 0.5f, spawnRate);
    }


    private void SpawnBlock()
    {
        Vector3 spawnPos = spawnPoint.position;

        spawnPos.x = Random.Range(-maxX, maxX);

        Instantiate( block, spawnPos, Quaternion.identity );
    }
}
