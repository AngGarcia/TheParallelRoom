using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class invokeEvent : MonoBehaviour
{
    // Start is called before the first frame update

    public UnityEvent animation;

    public void eventInvoker()
    {
        animation.Invoke();
    }
}
