using UnityEngine;
using System.Collections;

public class ClimbableTree : MonoBehaviour, IClimbable {
    // A script for a tree that's climbable.
    // the basic script for climbable GameObjects
    [Tooltip("you can speed up or slow down the players climbing speed with this. 1 = default speed")]
    public float climbEase;
    public float climbSpeedMultiplier
    {
        get { return climbEase; }
        set { climbEase = value; }
    }

    public void OnActivate(GameObject climber)
    {
        return;
    }

    public void OnDeactivate(GameObject climber)
    {
        return;
    }
}
