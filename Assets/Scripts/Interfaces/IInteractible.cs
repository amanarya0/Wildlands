using UnityEngine;


    public interface IInteractible
    {
    // the base interface for interactible objects (vines, breakable branches / etc).
    // used to make sure the API should be easy to use and easily expandable.
    // changes that apply to ALL interactable objects should be made here.

    // should be called by player/ whoever activates this.
    // may or may not be used according to our needs for each object
    void OnActivate(GameObject obj);
    void OnDeactivate(GameObject obj);

}