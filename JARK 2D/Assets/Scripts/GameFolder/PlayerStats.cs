using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public int startMP = 5;
    private int currMP;
    public float startX = 0f;
    public float startY = 0f;
    private (float x, float y) currAffinity;
    public float stabilityThreshold = 5f;
    private AWScript wheel;

    public int GetCurrMP() {
        return currMP;
    }

    public void SetCurrMP(int v) {
        // Set current MP to v
        currMP = v;
    }

    public void UpdateCurrMP(int c) {
        // Update current MP, by removing c
        currMP -= c;
    }

    public (float x, float y) GetCurrAffinity() {
        return currAffinity;
    }

    public void SetCurrAffinity((float x, float y) v) {
        // Set current MP to v
        currAffinity = v;
    }
     
    public void UpdateCurrAffinity((float x, float y) c) {
        // Update current MP, by ADDING c
        currAffinity.x += c.x;
        currAffinity.y += c.y;
    }

    public bool affinityIsStable() =>
        //return Mathf.Sqrt(currAffinity.x * currAffinity.x + currAffinity.y * currAffinity.y) < stabilityThreshold;
        wheel.Stability;
    // Start is called before the first frame update
    void Start()
    {
        wheel = GameObject.Find("Affinity_Wheel").GetComponent<AWScript>();
        SetCurrMP(startMP);
        SetCurrAffinity((startX, startY));
    }
}
