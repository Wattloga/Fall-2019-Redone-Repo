using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class GameAction : MonoBehaviour
{
   public UnityAction action;
   public UnityAction<Transform> transformAction;

   public void Raise()
   {
      action?.Invoke();
   }

   public void Raise(Transform transformObj)
   {
      transformAction?.Invoke(transformObj);
   }
}
