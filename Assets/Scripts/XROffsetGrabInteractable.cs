using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class XROffsetGrabInteractable : XRGrabInteractable
{

    private Vector3 intlocalpos;
    private Quaternion intlocalrot;

    void Start()
    {
        if(!attachTransform)
        {
            GameObject attachPoint = new GameObject("Offset Grab Pivot");
            attachPoint.transform.SetParent(transform, false);
            attachTransform = attachPoint.transform;
        }
        else
        {
            intlocalpos = attachTransform.localPosition;
            intlocalrot = attachTransform.localRotation;
        }
    }


    protected override void OnSelectEntered(SelectEnterEventArgs args)
    {
        if(args.interactableObject is XRDirectInteractor)
        {
            attachTransform.position = args.interactableObject.transform.position;
            attachTransform.rotation = args.interactableObject.transform.rotation;
        }
        else
        {
            attachTransform.localPosition = intlocalpos;
            attachTransform.localRotation = intlocalrot;
        }


        

        base.OnSelectEntered(args);
    }
}
