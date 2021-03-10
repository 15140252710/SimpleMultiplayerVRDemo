using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalData : MonoBehaviour
{
    public static GlobalData instance { get; private set; }

    public bool IsServer;//是否是服务器


    private void Awake() {
        DontDestroyOnLoad(gameObject);
        if (instance == null) {
            instance = this;
        }
    }
}
