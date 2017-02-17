using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Manager : MonoBehaviour {
    public Texture[] images;
    private int curImageNumber;
    public GameObject projectionSphere;
    public float clickCooldownTimer;
    public bool canClick;

    void Awake() {
        canClick = true;
    }

    void Update() {
        //Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved
        if (canClick) {
            //Input.touchCount > 0
            if (Input.touchCount > 0) {
                if (curImageNumber >= images.Length - 1) {
                    curImageNumber = 0;
                } else {
                    curImageNumber++;
                }
                projectionSphere.GetComponent<Renderer>().material.mainTexture = images[curImageNumber];
                canClick = false;
                StartCoroutine("Cooldown");
                print("Cooldown started");

            }

        }
    }
    IEnumerator Cooldown() {

        yield return new WaitForSeconds(clickCooldownTimer);
        canClick = true;
        print("Cooldown stopped");
        StopCoroutine("Cooldown");

    }
}
