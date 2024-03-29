﻿using BeardedManStudios.Forge.Networking.Unity;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnplayer : MonoBehaviour
{
    private List<Transform> spawnPoints = new List<Transform>();
    public List<Transform> SpawnPoints { get { return spawnPoints; } }
    // Use this for initialization
    void Start()
    {
        //get all the children
        for (int i = 0; i < transform.childCount; i++)
        {
            spawnPoints.Add(transform.GetChild(i));
            //remove the physical appearence of the spawnpoints
            transform.GetChild(i).gameObject.SetActive(false);
        }
        //Find a random spawnpoint from the list
        Vector3 randomSpawnPosition = spawnPoints[UnityEngine.Random.Range(0, spawnPoints.Count)].position;
        //Instantiate the player
        var player = NetworkManager.Instance.InstantiatePlayer(position: randomSpawnPosition);
        player.transform.position = randomSpawnPosition;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
