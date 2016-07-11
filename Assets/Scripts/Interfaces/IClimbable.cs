using UnityEngine;
using System.Collections;

public interface IClimbable : IInteractible {
    // An interface for all scripts that invlove climbable objects.
    // meant to be implemented in every script that defines a climbable object
    // so that if we want to make a custom object later, that doesn't work
    // like the basic script for climbable objects, the API doesn't become a mess.
    float climbSpeedMultiplier { get; set; }
}
