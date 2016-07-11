using UnityEngine;
using System.Collections;

public class DisableColliderOnTrigger : MonoBehaviour {
    public GameObject objectToDisable;
    public Collider2D colliderToDisable;
    public GameObject player; // the object that can activate the trigger

    private bool isEnabled = true; // true if the collider is disabled, false otherwise

    // circle collider vars
    private Bounds colliderBounds;

    void Awake()
    {
        // if player not set, find by tag
        if (!player)
            player = GameObject.FindGameObjectWithTag("Player");


    }

    void Start()
    {

    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        if(coll.gameObject == player && isEnabled)
        {
            objectToDisable.SetActive(false);
            isEnabled = false;
        }
    }

    void OnTriggerExit2D(Collider2D coll)
    {
        if (coll.gameObject == player && !isEnabled)
        {
            objectToDisable.SetActive(true);
            isEnabled = true;
        }
    }

	
	// Update is called once per frame
	void Update () {
	
	}


    void IsInColliderBounds(Vector2 point)
    {
    }
}
