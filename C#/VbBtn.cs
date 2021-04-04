using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Vuforia;

public class VirtualBtn : MonoBehaviour
{

    public GameObject vbBtnObj;
    public Animator SphereAni;

    // Use this for initialization
    void Start()
    {
        vbBtnObj = GameObject.Find("lacieBtn");
        vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
        vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);

        SphereAni.GetComponent<Animator>();
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        SphereAni.Play("Big Planet Animation");
        Debug.Log("Button pressed");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        SphereAni.Play("none");
        Debug.Log("Button released");
    }
}
