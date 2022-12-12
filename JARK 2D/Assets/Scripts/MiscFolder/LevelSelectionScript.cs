using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class LevelSelectionScript : MonoBehaviour
{
    // Start is called before the first frame update
    public void LoadScene(){
        //only level 1 scene is created and added to build settings as of now.
        //add the rest in later
        string name = EventSystem.current.currentSelectedGameObject.name; 
        SceneManager.LoadScene(name);
    }
}
