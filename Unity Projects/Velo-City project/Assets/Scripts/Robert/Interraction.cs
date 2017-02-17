using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interraction : MonoBehaviour {
    public enum TypeOffInterraction {NPC,Door}
    public Door door;
    public NPC npc;

    public TypeOffInterraction typeOffObject;

    public void Interract() {
        switch (typeOffObject) {
            case TypeOffInterraction.NPC:
                npc.Interract();
                break;
            case TypeOffInterraction.Door:
                door.DoorInterraction();
                break;  
        }
    }
}
[System.Serializable]
public class Door : Interraction  {
    public Transform door1;
    public Transform door2;
    private bool isOpen;
    public float openAngle;
    public void DoorInterraction() {
        if (isOpen) {
            Close();
            isOpen = false;
        } else if (!isOpen) {
            Open();
            isOpen = true;
        }
    }

    void Close() {
        // play closing animation
    }

    void Open() {
        // play opening animation
    }
}
[System.Serializable]
public class NPC : Interraction {
    public Canvas canvas;
    private bool canvasIsActive;
    public string textToSay;
    public Text text;
    public void Interract() {
        
    }
}

