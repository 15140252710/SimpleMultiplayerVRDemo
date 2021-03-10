using BeardedManStudios.Forge.Networking.Unity;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelReady : MonoBehaviour
{
    public static LevelReady instance;

    [SerializeField] private GameObject serverCameraGo;
    public GameObject TeleportAreaA;
    public GameObject TeleportAreaB;

    public Text text;

    private void Awake() {
        if (instance == null) {
            instance = this;
        }
    }

    // Start is called before the first frame update
    void Start() {
        //是服务端
        if (GlobalData.instance.IsServer) {
            //生成GameLogic
            NetworkManager.Instance.InstantiateGameLogic();
            //显示服务端相机
            serverCameraGo.SetActive(true);
            //生成可抓取的盒子
            NetworkManager.Instance.InstantiateTestCube(0);
            NetworkManager.Instance.InstantiateTestCube(1);
            NetworkManager.Instance.InstantiateTestCube(2);
            NetworkManager.Instance.InstantiateTestCube(3);
            NetworkManager.Instance.InstantiateTestCube(4);
            NetworkManager.Instance.InstantiateTestCube(5);
        }
        //不是服务端
        else if (!GlobalData.instance.IsServer) {
            //创建player
            NetworkManager.Instance.InstantiateVRPlayer();
        }
    }
}
