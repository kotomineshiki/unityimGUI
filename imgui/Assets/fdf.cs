using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fdf : MonoBehaviour {

    // Use this for initialization
    void Awake() { Debug.Log(1); }

    void Start() { Debug.Log(2); }

    void Update() { Debug.Log(3); }

    void FixedUpdate() { Debug.Log(4); }
    private void LateUpdate()
    {
        Debug.Log(6);
    }
}
