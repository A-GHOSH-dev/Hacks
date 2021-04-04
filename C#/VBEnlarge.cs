using UnityEngine;
using UnityEngine.Events;
using Vuforia;

public class VBEnalrge : MonoBehaviour
{

    public GameObject vbBtnObj;
    public Animator skeleton;

    // Use this for initialization
    void Start()
    {
        vbBtnObj = GameObject.Find("Enlarge");
        vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
        vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);

        skeleton.GetComponent<Animator>();
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        skeleton.Play("skeletonAni");
        Debug.Log("Button pressed");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        skeleton.Play("none");
        Debug.Log("Button released");
    }
}
