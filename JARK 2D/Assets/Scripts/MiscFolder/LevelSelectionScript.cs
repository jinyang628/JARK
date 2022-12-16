using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class LevelSelectionScript : MonoBehaviour
{
    public Button Button0, Button1, Button2, Button3, Button4, Button5, Button6, Button7, Button8, Button9, Button10, Button11, Button12, Button13, Button14;
    int levelPassed;

    void Start(){
        levelPassed = PlayerPrefs.GetInt("LevelPassed");
        Button2.interactable = false;
        Button3.interactable = false;
        Button4.interactable = false;
        Button5.interactable = false;
        Button6.interactable = false;
        Button7.interactable = false;
        Button8.interactable = false;

        switch (levelPassed){
            case 1:
                Button2.interactable = true;
                break;
            case 2:
                Button2.interactable = true;
                Button3.interactable = true;
                break;
            case 3:
                Button2.interactable = true;
                Button3.interactable = true;
                Button4.interactable = true;
                break;
            case 4:
                Button2.interactable = true;
                Button3.interactable = true;
                Button4.interactable = true;
                Button5.interactable = true;
                break;
            case 5:
                Button2.interactable = true;
                Button3.interactable = true;
                Button4.interactable = true;
                Button5.interactable = true;
                Button6.interactable = true;
                break;
            case 6:
                Button2.interactable = true;
                Button3.interactable = true;
                Button4.interactable = true;
                Button5.interactable = true;
                Button6.interactable = true;
                Button7.interactable = true;
                break;
            case 7:
                Button2.interactable = true;
                Button3.interactable = true;
                Button4.interactable = true;
                Button5.interactable = true;
                Button6.interactable = true;
                Button7.interactable = true;
                Button8.interactable = true;
                break;
            case 8:
                Button2.interactable = true;
                Button3.interactable = true;
                Button4.interactable = true;
                Button5.interactable = true;
                Button6.interactable = true;
                Button7.interactable = true;
                Button8.interactable = true;
                Button9.interactable = true;
                break;
            case 9:
                Button2.interactable = true;
                Button3.interactable = true;
                Button4.interactable = true;
                Button5.interactable = true;
                Button6.interactable = true;
                Button7.interactable = true;
                Button8.interactable = true;
                Button9.interactable = true;
                Button10.interactable = true;
                break;
            case 10:
                Button2.interactable = true;
                Button3.interactable = true;
                Button4.interactable = true;
                Button5.interactable = true;
                Button6.interactable = true;
                Button7.interactable = true;
                Button8.interactable = true;
                Button9.interactable = true;
                Button10.interactable = true;
                Button11.interactable = true;
                break;
            case 11:
                Button2.interactable = true;
                Button3.interactable = true;
                Button4.interactable = true;
                Button5.interactable = true;
                Button6.interactable = true;
                Button7.interactable = true;
                Button8.interactable = true;
                Button9.interactable = true;
                Button10.interactable = true;
                Button11.interactable = true;
                Button12.interactable = true;
                break;
            case 12:
                Button2.interactable = true;
                Button3.interactable = true;
                Button4.interactable = true;
                Button5.interactable = true;
                Button6.interactable = true;
                Button7.interactable = true;
                Button8.interactable = true;
                Button9.interactable = true;
                Button10.interactable = true;
                Button11.interactable = true;
                Button12.interactable = true;
                Button13.interactable = true;
                break;
            case 13:
                Button2.interactable = true;
                Button3.interactable = true;
                Button4.interactable = true;
                Button5.interactable = true;
                Button6.interactable = true;
                Button7.interactable = true;
                Button8.interactable = true;
                Button9.interactable = true;
                Button10.interactable = true;
                Button11.interactable = true;
                Button12.interactable = true;
                Button13.interactable = true;
                Button14.interactable = true;
                break;
        }
    }

    public void LoadScene(){
        string name = EventSystem.current.currentSelectedGameObject.name; 
        SceneManager.LoadScene(name);
    }
}
