using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VideoVierwer : MonoBehaviour {

    public GameObject leftSphere, rightSphere;

    void Awake() {
        ((MovieTexture)leftSphere.GetComponent<Renderer>().material.mainTexture).Play();
        ((MovieTexture)rightSphere.GetComponent<Renderer>().material.mainTexture).Play();
    }
}
