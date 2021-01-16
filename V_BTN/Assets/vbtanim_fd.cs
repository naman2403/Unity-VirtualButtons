using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class vbtanim_fd : MonoBehaviour,IVirtualButtonEventHandler
{
    public GameObject vbtnobject1;
    public Animator cubeani_fd;
    // Start is called before the first frame update
    void Start()
    {

        vbtnobject1 = GameObject.Find("VBTNW");
        vbtnobject1.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        cubeani_fd.GetComponent<Animator>();
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        cubeani_fd.Play("cube_animation1");
        Debug.Log("BTN pressed");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        cubeani_fd.Play("none");
        Debug.Log("BTN released");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
