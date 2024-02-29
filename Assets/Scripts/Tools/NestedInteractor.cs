using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class NestedInteractor : MonoBehaviour
{
    private XRGrabInteractable xrGrabInteractable;
    private XRDirectInteractor xrInteractor;
    private ActionBasedController controller;

    private InputActionProperty dummyActionProperty;

    private void Awake()
    {
        xrGrabInteractable = GetComponentInParent<XRGrabInteractable>();
        xrInteractor = GetComponent<XRDirectInteractor>();
        controller = GetComponent<ActionBasedController>();

        dummyActionProperty = new InputActionProperty();

        controller.selectAction = dummyActionProperty;
    }

    private void OnEnable()
    {
        xrGrabInteractable.selectEntered.AddListener(InteractableSelected);
        xrGrabInteractable.selectExited.AddListener(InteractableUnselected);
    }

    private void OnDisable()
    {
        xrGrabInteractable.selectEntered.RemoveListener(InteractableSelected);
        xrGrabInteractable.selectExited.RemoveListener(InteractableUnselected);
    }

    private void InteractableSelected(SelectEnterEventArgs arg0)
    {
        var interactor = arg0.interactorObject;
        ActionBasedController handController = interactor.transform.GetComponent<ActionBasedController>();

        controller.selectAction = handController.activateAction;
    }

    private void InteractableUnselected(SelectExitEventArgs arg0)
    {
        controller.selectAction = dummyActionProperty;
    }
}
