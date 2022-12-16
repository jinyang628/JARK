using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DemoScenes : MonoBehaviour
{
    // Start is called before the first frame update
    public void GoDemo(){
        SceneManager.LoadScene(this.name);
    }
}
