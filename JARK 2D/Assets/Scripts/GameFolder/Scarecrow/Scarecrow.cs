using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scarecrow : MonoBehaviour
{
    public GameObject TempRestartWalls;
    public GameObject TempWalls;
    public Animator _animator;
    public GameObject instructions2;

    private void OnTriggerEnter2D(Collider2D col){
        if (col.gameObject.name == "Player"){
            Destroy(TempRestartWalls);
            Destroy(TempWalls);
            _animator.SetTrigger("OnScarecrowCollision");
            StartCoroutine(Wait());
        }
    }

    IEnumerator Wait(){
        yield return new WaitForSeconds(2);
        instructions2.SetActive(true);  
    }
}
