using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class vbtanim_rt : MonoBehaviour,IVirtualButtonEventHandler
{
    public GameObject vbtnobject4;
    public Animator cubeani_rt;
    // Start is called before the first frame update
    void Start()
    {
        vbtnobject4 = GameObject.Find("VBTND");
        vbtnobject4.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        cubeani_rt.GetComponent<Animator>();
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        cubeani_rt.Play("cube_animation4");
        Debug.Log("BTN pressed");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        cubeani_rt.Play("none");
        Debug.Log("BTN released");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
