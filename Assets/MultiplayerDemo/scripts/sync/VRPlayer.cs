using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BeardedManStudios.Forge.Networking;
using BeardedManStudios.Forge.Networking.Generated;

public class VRPlayer : VRPlayerBehavior
{

    public GameObject ownerGo;
    public GameObject notOwnerGo;

    public Transform playerTf;
    public Transform ownerHeadTf;
    public Transform ownerLHandTf;
    public Transform ownerRHandTf;

    public Transform notOwnerHeadTf;
    public Transform notOwnerLHandTf;
    public Transform notOwnerRHandTf;

    public GameObject hat_blue;
    public GameObject hat_yellow;

    public uint NetworkID { get; private set; }
    public string IP { get; private set; }

    public string PlayerIdentity;// A/B

    protected override void NetworkStart() {
        base.NetworkStart();

        ownerGo.SetActive(networkObject.IsOwner);
        notOwnerGo.SetActive(!networkObject.IsOwner);

        if (networkObject.IsOwner) {
            //发送自己的网络ID
            SendNetworkID();
            
        }
        if (networkObject.IsServer) {
            //使用GameLogic，添加VRPlayer
            AddPlayer();
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if (networkObject == null) return;

        if (!networkObject.IsOwner) {
            //同步位置，头和手
            playerTf.position = networkObject.playerPos;
            playerTf.rotation = networkObject.playerRot;
            notOwnerHeadTf.position = networkObject.headPos;
            notOwnerHeadTf.rotation = networkObject.headRot;
            notOwnerLHandTf.position = networkObject.lHandPos;
            notOwnerLHandTf.rotation = networkObject.lHandRot;
            notOwnerRHandTf.position = networkObject.rHandPos;
            notOwnerRHandTf.rotation = networkObject.rHandRot;
            notOwnerLHandTf.gameObject.SetActive(networkObject.lHandActive);
            notOwnerRHandTf.gameObject.SetActive(networkObject.rHandActive);
            return;
        }

        //同步位置，头和手
        networkObject.playerPos = playerTf.position;
        networkObject.playerRot = playerTf.rotation;
        networkObject.headPos = ownerHeadTf.position;
        networkObject.headRot = ownerHeadTf.rotation;
        networkObject.lHandPos = ownerLHandTf.position;
        networkObject.lHandRot = ownerLHandTf.rotation;
        networkObject.rHandPos = ownerRHandTf.position;
        networkObject.rHandRot = ownerRHandTf.rotation;
        networkObject.lHandActive = ownerLHandTf.gameObject.activeSelf;
        networkObject.rHandActive = ownerRHandTf.gameObject.activeSelf;

    }

    public void AddPlayer() {
        GameLogic.instance.AddPlayer(this);
    }

    private void InitPlayerTeleportArea() {
        if (PlayerIdentity == "A") {
            //显示A角色，专属区域
            LevelReady.instance.TeleportAreaA.SetActive(true);
        }else if (PlayerIdentity == "B") {
            //显示B角色，专属区域
            LevelReady.instance.TeleportAreaB.SetActive(true);
        }

        //delete
        LevelReady.instance.text.text = PlayerIdentity;
    }

    public void SendNetworkID() {
        uint id = networkObject.MyPlayerId;
        networkObject.SendRpc(RPC_SEND_NETWORK_ID_SYNC, Receivers.All, id);
    }

    //区分身份，同步身份信息到其他端。判断身份是在GameLogic中做的
    public void SendPlayerIdentity(string identity) {// identity=A/B
        networkObject.SendRpc(RPC_SEND_PLAYER_IDENTITY_SYNC, Receivers.All, identity);
    }

    //获取网络ID
    public override void SendNetworkIdSync(RpcArgs args) {
        this.NetworkID = args.GetNext<uint>();
    }

    public override void SendPlayerIdentitySync(RpcArgs args) {
        this.PlayerIdentity = args.GetNext<string>();

        if (networkObject.IsOwner) {
            InitPlayerTeleportArea();
        }

        if (PlayerIdentity == "A") {
            hat_blue.SetActive(true);
        }
        if (PlayerIdentity == "B") {
            hat_yellow.SetActive(true);
        }

    }
}
