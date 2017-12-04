using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryObject : MonoBehaviour, IActivatable {
    [SerializeField]
    private string nameText;

    public string NameText
    {
        get
        {
            return nameText;
        }

        set
        {
            throw new System.NotImplementedException();
        }
    }

    public void DoActivate()
    {
        throw new System.NotImplementedException();
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
