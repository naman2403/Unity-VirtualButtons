using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class vbtanim_lt : MonoBehaviour,IVirtualButtonEventHandler
{
    public GameObject vbtnobject3;
    public Animator cubeani_lt;
    // Start is called before the first frame update
    void Start()
    {
        vbtnobject3 = GameObject.Find("VBTNA");
        vbtnobject3.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        cubeani_lt.GetComponent<Animator>();
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        cubeani_lt.Play("cube_animation3");
        Debug.Log("BTN pressed");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        cubeani_lt.Play("none");
        Debug.Log("BTN released");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
