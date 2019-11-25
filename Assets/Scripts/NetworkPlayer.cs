using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BeardedManStudios.Forge.Networking.Generated;
using UnityEngine.Events;
using BeardedManStudios.Forge.Networking;
using System;
using BeardedManStudios.Forge.Networking.Unity;
using static UnityEngine.UI.Toggle;

public class NetworkPlayer : PlayerBehavior
{

    public event System.Action<RpcArgs> TakeDamageEvent;
    public event System.Action<RpcArgs> SetupPlayerEvent;
    public event System.Action<RpcArgs> DieEvent;
    [SerializeField]
    //the health system script
    private HealthSystem hp;

    private bool canMove = true;
    //also make an event for the network start as some components need that as well
    public event System.Action NetworkStartEvent;

    [SerializeField]
    private GameObject playerModel;

    [SerializeField]
    ToggleEvent ownerScripts;

    //The player's camera
    private Camera playerCamera;

    void Start()
    {
        //Get the HP system and it's events, as we need logic based on that.
        //Eg we can't move if the player is dead
        hp.OnPlayerDie += Hp_OnPlayerDie;
        hp.OnPlayerRespawn += Hp_OnPlayerRespawn;
    }

    private void Hp_OnPlayerRespawn()
    {
        //the player can move again on respawn
        canMove = true;
    }

    /// <summary>
    /// Called from OnPlayerDie from the HealthSystem
    /// Force stop the player and make him unable to move
    /// </summary>
    /// <param name="attackerName"></param>
    private void Hp_OnPlayerDie(string attackerName)
    {
        canMove = false;
    }


    public GameObject PlayerModel
    {
        get
        {
            return playerModel;
        }
    }

    public Camera PlayerCamera
    {
        get
        {
            return playerCamera;
        }
    }

    protected override void NetworkStart()
    {
        base.NetworkStart();

        //make a dynamic bool depending on we are the owner or not, and define the logic in the inspector.
        //eg some scripts should be disabled on non owners
        ownerScripts.Invoke(networkObject.IsOwner);

        //Get the player camera
        playerCamera = GetComponentInChildren<Camera>();


        //Disable the camera if we aren't the owner
        if (!networkObject.IsOwner)
        {
            playerCamera.gameObject.SetActive(false);
        }
        else if (networkObject.IsOwner)
        {
            //Enable the HUD if we are the owner (it's disabled in the prefab)
            //HUD.SetActive(true);
            //call the network start event
            if (NetworkStartEvent != null)
            {
                NetworkStartEvent();
            }
        }

        if (NetworkManager.Instance.Networker is IServer)
        {
            //here you can also do some server specific code
        }
        else
        {
            //setup the disconnected event
            NetworkManager.Instance.Networker.disconnected += DisconnectedFromServer;

        }
    }

    private void DisconnectedFromServer(NetWorker sender)
    {
        NetworkManager.Instance.Networker.disconnected -= DisconnectedFromServer;

        MainThreadManager.Run(() =>
        {
            //Loop through the network objects to see if the disconnected player is the host
            foreach (var no in sender.NetworkObjectList)
            {
                if (no.Owner.IsHost)
                {
                    BMSLogger.Instance.Log("Server disconnected");
                    //Should probably make some kind of "You disconnected" screen. ah well
                    UnityEngine.SceneManagement.SceneManager.LoadScene(0);
                }
            }

            NetworkManager.Instance.Disconnect();
        });
    }

    void FixedUpdate()
    {
        if (networkObject.IsOwner)
        {
            //set the position and the rotation 
            networkObject.position = transform.position;
            networkObject.rotation = playerModel.transform.rotation;
        }
        else //non owner, meaning a remote playe
        {
            //receive all NCW fields and use them
            transform.position = networkObject.position;
            playerModel.transform.rotation = networkObject.rotation;
        }

    }

    public override void TakeDamage(RpcArgs args)
    {
        if (TakeDamageEvent != null)
        {
            TakeDamageEvent(args);
        }
    }

    public override void SetupPlayer(RpcArgs args)
    {
        if (SetupPlayerEvent != null)
        {
            SetupPlayerEvent(args);
        }
    }

    public override void Die(RpcArgs args)
    {
        if (DieEvent != null)
        {
            DieEvent(args);
        }
    }

    private void OnDestroy()
    {
        hp.OnPlayerDie -= Hp_OnPlayerDie;
        hp.OnPlayerRespawn -= Hp_OnPlayerRespawn;
    }
}
