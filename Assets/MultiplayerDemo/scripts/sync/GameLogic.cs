using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BeardedManStudios.Forge.Networking;
using BeardedManStudios.Forge.Networking.Generated;
using BeardedManStudios.Forge.Networking.Unity;

public class GameLogic : GameLogicBehavior
{
    public static GameLogic instance { get; private set; }

    public List<VRPlayer> vrPlayerList = new List<VRPlayer> { };
    private Dictionary<uint, string> vrPlayerIDIPDict = new Dictionary<uint, string> { };

    private void Awake() {
        if (instance == null) {
            instance = this;
        }
    }

    protected override void NetworkStart() {
        base.NetworkStart();

        if(networkObject.IsServer&&NetworkManager.Instance.Networker is IServer) {

            NetWorker server = NetworkManager.Instance.Networker;

            server.playerConnected += (player, sender) => {
                Debug.Log("<color=green>Player " + player.NetworkId + " - " + player.Ip + " connected </color>" + server.Players.Count);

                vrPlayerIDIPDict.Add(player.NetworkId, player.Ip);
 
            };

            server.playerDisconnected += (player, sender) => {
                Debug.Log("<color=red>Player " + player.NetworkId + " - " + player.Ip + " disconnected </color>");

                for (int i = 0; i < vrPlayerList.Count; i++) {
                    if (vrPlayerList[i].NetworkID == player.NetworkId) {
                        VRPlayer plGo = vrPlayerList[i];

                        //MainThreadManager.Run(() => {
                        //    if (GlobalData.instance.isServer) {
                        //        SendServerMessage("<color=red>" + plGo.playerName + " 离开了游戏</color>");
                        //    }
                        //});

                        vrPlayerList.RemoveAt(i);
                        plGo.networkObject.TakeOwnership();
                        plGo.networkObject.Destroy(1000);
                    }
                }
            };
        }
    }

    public void AddPlayer(VRPlayer player) {
        vrPlayerList.Add(player);
        Debug.Log("Add Player " + player.IP);

        if (vrPlayerList.Count <= 1) {
            player.SendPlayerIdentity("A");
        }else if (vrPlayerList.Count >= 2) {
            player.SendPlayerIdentity("B");
        }
    }

}
