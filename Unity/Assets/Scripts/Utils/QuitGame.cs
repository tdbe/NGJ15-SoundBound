﻿using UnityEngine;
using System.Collections;

public class QuitGame : MonoBehaviour {

    static QuitGame singleton;

    void Awake() {
        singleton = this;
    }

    void Start() {
        if (singleton == null) {
            DontDestroyOnLoad(this.gameObject);
        } else {
            Destroy(this.gameObject);
        }
    }

    void Update() {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            Application.Quit();
        }
    }
}
