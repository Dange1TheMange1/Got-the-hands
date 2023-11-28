using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class HandAnims : MonoBehaviour
{
    public InputActionProperty pinchAnim;
    public InputActionProperty grabAnim;

    public Animator handAnim;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //no need to debug it just works
        float pinchValue = pinchAnim.action.ReadValue<float>();
        handAnim.SetFloat("Pinch", pinchValue);

        float grabValue = grabAnim.action.ReadValue<float>();
        handAnim.SetFloat("Grab", grabValue);
    }
}
