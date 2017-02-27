using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Manager : MonoBehaviour {
    public Texture[] images;
    private int curImageNumber;
    public GameObject projectionSphere;
    public float switchCooldownTimer;
    public bool canSwitch;

    void Awake() {
        canSwitch = true;
    }

    void Update() {
        
        //Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved
        if (canSwitch) {
            //Input.touchCount > 0
            canSwitch = false;
                if (curImageNumber >= images.Length - 1) {
                    curImageNumber = 0;
                } else {
                    curImageNumber++;
                }
                projectionSphere.GetComponent<Renderer>().material.mainTexture = images[curImageNumber];
                canSwitch = false;
                StartCoroutine("Cooldown");
                print("Cooldown started");

            }
    }
    IEnumerator Cooldown() {
        canSwitch = false;

        yield return new WaitForSeconds(switchCooldownTimer);

        print(switchCooldownTimer);
        canSwitch = true;
        print("Cooldown stopped");
        StopCoroutine("Cooldown");

    }
}
