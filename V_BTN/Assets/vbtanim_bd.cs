using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class vbtanim_bd : MonoBehaviour,IVirtualButtonEventHandler
{
    public GameObject vbtnobject2;
    public Animator cubeani_bd;
    // Start is called before the first frame update
    void Start()
    {
        vbtnobject2 = GameObject.Find("VBTNS");
        vbtnobject2.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        cubeani_bd.GetComponent<Animator>();
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        cubeani_bd.Play("cube_animation2");
        Debug.Log("BTN pressed");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        cubeani_bd.Play("none");
        Debug.Log("BTN released");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
