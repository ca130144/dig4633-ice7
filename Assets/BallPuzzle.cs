using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.XR.Interaction.Toolkit;

public class BallPuzzle : MonoBehaviour
{
    [SerializeField]
    public UnityEvent onSolve;

    public XRSocketInteractor interactor1;
    public XRSocketInteractor interactor2;
    public XRSocketInteractor interactor3;

    public Transform interactable1;
    public Transform interactable2;
    public Transform interactable3;

    public void CheckForSolution()
    {
        IXRSelectInteractable interactable1 = interactor1.GetOldestInteractableSelected();
        IXRSelectInteractable interactable2 = interactor2.GetOldestInteractableSelected();
        IXRSelectInteractable interactable3 = interactor3.GetOldestInteractableSelected();
        if (interactable1 != null && interactable2 != null && interactable3 != null &&
            interactable1.transform == this.interactable1 &&
            interactable2.transform == this.interactable2 &&
            interactable3.transform == this.interactable3)
            onSolve.Invoke();
    }
}
