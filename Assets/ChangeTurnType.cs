using System.Collections;
using System.Collections.Generic;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine;

public class ChangeTurnType : MonoBehaviour
{
   public ActionBasedContinuousTurnProvider continuousTurn;
   public ActionBasedSnapTurnProvider snapTurn;


    public void SetTurnTypeIndex(int index)
    {
        if(index == 0)
        {
            snapTurn.enabled = false;
            continuousTurn.enabled = true;
        }
        else if(index == 1)
        {
            snapTurn.enabled = true;
            continuousTurn.enabled = false;
        }

    }



}
