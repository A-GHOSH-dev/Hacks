using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Vuforia;

public class VirtualBtn : MonoBehaviour
{

    public GameObject vbBtnObj;
    public Animator Sphere;

    // Use this for initialization
    void Start()
    {
        vbBtnObj = GameObject.Find("lacieBtn");
        vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
        vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);

        Sphere.GetComponent<Animator>();
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Sphere.Play("Big Planet Animation");
        Debug.Log("Button pressed");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Sphere.Play("none");
        Debug.Log("Button released");
    }
}
