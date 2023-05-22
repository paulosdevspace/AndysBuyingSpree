using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItenGiveaway : ClientInteraction
{
    public clientbehaviour clientbehaviour;
    public override void Interact()
    {
        base.Interact();
        Give();
    }
    void Give()
    {
        
        clientbehaviour.hastoy++;
    }
}
