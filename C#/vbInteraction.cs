using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class vbInteraction : MonoBehaviour, IVirtualButtonEventHandler
{
    VirtualButtonBehaviour[] virtualButtonBehaviours;
    string vbName;
    public GameObject firstPanel, secondPanel, cube, sphere, capsule, cylinder;

    void Start()
    {
        //Register with the virtual buttons TrackableBehaviour
        virtualButtonBehaviours = GetComponentsInChildren<VirtualButtonBehaviour>();

        for (int i = 0; i < virtualButtonBehaviours.Length; i++)
            virtualButtonBehaviours[i].RegisterEventHandler(this);
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        vbName = vb.VirtualButtonName;

        if (vbName == "VirtualButtonChange")
            VirtualButtonChange();
        else if (firstPanel.activeInHierarchy)
        {
            Deactivate();
            if (vbName == "VirtualButton1")
                Btn1();
            else if (vbName == "VirtualButton2")
                Btn2();
        }
        else
        {
            Deactivate();
            if (vbName == "VirtualButton1")
                Btn3();
            else if (vbName == "VirtualButton2")
                Btn4();
        }
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {

    }

    void VirtualButtonChange()
    {
        if (firstPanel.activeInHierarchy)
        {
            firstPanel.SetActive(false);
            secondPanel.SetActive(true);
        }
        else
        {
            firstPanel.SetActive(true);
            secondPanel.SetActive(false);
        }
    }

    void Deactivate()
    {
        cube.SetActive(false);
        sphere.SetActive(false);
        capsule.SetActive(false);
        cylinder.SetActive(false);
    }

    void Btn1()
    {
        cube.SetActive(true);
    }

    void Btn2()
    {
        sphere.SetActive(true);
    }

    void Btn3()
    {
        capsule.SetActive(true);
    }

    void Btn4()
    {
        cylinder.SetActive(true);
    }
}
