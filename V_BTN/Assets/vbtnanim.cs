using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
public class vbtnanim : MonoBehaviour,IVirtualButtonEventHandler
{
    // Start is called before the first frame update
    public GameObject vbtnobject;
    public Animator cubeani;
    void Start()
    {
        vbtnobject = GameObject.Find("VBTNR");
        vbtnobject.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        cubeani.GetComponent<Animator>();
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        cubeani.Play("cube_animation");
        Debug.Log("BTN pressed");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        cubeani.Play("none");
        Debug.Log("BTN released");
    }
    // Update is called once per frame
    
}
