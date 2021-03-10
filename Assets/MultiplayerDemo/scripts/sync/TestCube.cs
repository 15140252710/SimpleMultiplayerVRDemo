using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BeardedManStudios.Forge.Networking;
using BeardedManStudios.Forge.Networking.Generated;
using Valve.VR.InteractionSystem;

public class TestCube : TestCubeBehavior
{
    private void Start() {
        Throwable ta = GetComponent<Throwable>();
        ta.onPickUp.AddListener(OnGrabHandler);
    }
    protected override void NetworkStart() {
        base.NetworkStart();
    }

    private void Update() {

        if (networkObject == null) return;

        if (!networkObject.IsOwner) {
            transform.position = networkObject.pos;
            transform.rotation = networkObject.rot;
            return;
        }

        networkObject.pos = transform.position;
        networkObject.rot = transform.rotation;
    }

    //抓取
    public void OnGrabHandler() {
        networkObject.TakeOwnership();
    }

    //松开
    public void OnDetachHandler() {

    }
}
