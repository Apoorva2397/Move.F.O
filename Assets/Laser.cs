using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour {
   private Vector2 start;
   private Vector2 End;
   CompletePlayerController PlayerController;
    public void Start()
    {
        //PlayerController = gameObject.GetComponent<CompletePlayerController>();
    }
    private void Awake()
    {
        
    }
    // Use this for initialization
    
	
	// Update is called once per frame
	void FixedUpdate () {
        
        Debug.DrawLine(start, End, Color.red);

    }
    private void Update()
    {
       RaycastHit2D hit = Physics2D.Raycast(start, Vector2.left, 50.0f);
        if (hit.transform.gameObject.name == "Player")
            Destroy(hit.transform.gameObject);
            PlayerController.killPlayer(3);
    }
}
