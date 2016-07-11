﻿using UnityEngine;
using System.Collections;

public class TEST : MonoBehaviour {
    public enum Mode { Start, Update, FixedUpdate }
    public Mode whenToDoStuff;
    // Use this for initialization

    void doStuff()
    {
        Debug.Log(string.Format("{0} realPos: {1}",
                                   gameObject.name,
                                   Helper.GetRealPos( GetComponent<CircleCollider2D>() )
                               )
                 );
    }   



    void Start()
    {
        if (whenToDoStuff == Mode.Start)
            doStuff();
    }
	void Update () {
        if (whenToDoStuff == Mode.Update)
            doStuff();
    }
    void FixedUpdate()
    {
        if (whenToDoStuff == Mode.FixedUpdate)
            doStuff();
    }
}
