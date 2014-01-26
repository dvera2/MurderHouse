﻿using UnityEngine;
using System.Collections;
using XInputDotNetPure;

public abstract class Player : MonoBehaviour {

    public int id;
    protected bool isMuderer;
    public Door nearestDoor;
    public Room currentRoom;

    public GameObject ActionAnim;
    public float ActionAnimSpeed = 1.0f;

    protected abstract void OnPressX();
    protected abstract void OnPressA();

    protected abstract void OnReleaseX();

    // Use this for initialization
    void Start () {

        ActionAnim.renderer.gameObject.SetActive(false);
    }

    void OpenDoor() {
        if ( nearestDoor )
            nearestDoor.open();
    }

    public void SetMurderer( bool murderer ) {
        this.isMuderer = murderer;
    }

    public PlayerIndex GetIndex() {
        switch ( this.id ) {
            case 1: return PlayerIndex.One;
            case 2: return PlayerIndex.Two;
            case 3: return PlayerIndex.Three;
            case 4: return PlayerIndex.Four;
            default: return PlayerIndex.One;
        }
    }
}
