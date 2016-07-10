using UnityEngine;
using System.Collections;

public class ClimbableTree : MonoBehaviour, IClimbable {
    // A script for a tree that's climbable.
    // the basic script for climbable GameObjects
	
	// Update is called once per frame
	void Update () {
	
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
