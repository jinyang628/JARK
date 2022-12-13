using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scarecrow : MonoBehaviour
{
    public GameObject TempWalls;
    public Animator _animator;

    private void OnTriggerEnter2D(Collider2D col){
        if (col.gameObject.name == "Player"){
            Destroy(TempWalls);
            _animator.SetTrigger("OnScarecrowCollision");
        }
    }
}
