using BeardedManStudios.Forge.Networking.Unity;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Only have the gamemode on the server
        if (NetworkManager.Instance.IsServer)
        {
            NetworkManager.Instance.InstantiateGame();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
