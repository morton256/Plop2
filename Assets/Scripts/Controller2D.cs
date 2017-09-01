using System.Collections;
using UnityEngine;

[RequireComponent (typeof (BoxCollider2D))]
public class Controller2D : MonoBehaviour {

    //TODO Add collisions

    #region Variables

    BoxCollider2D pCollider; // Player Collider box

    #endregion

    // Use this for initialization
    void Start () {
        pCollider = GetComponent<BoxCollider2D>();
	}

    // Public function used to translate the players position in the gameworld
    public void Move(Vector2 velocity)
    {
        //TODO add collision checks before applying translate

        transform.Translate(velocity);
    }
    
}
