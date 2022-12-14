using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameState : MonoBehaviour
{
    public static float player_x_coord;
    public static float player_y_coord;
    public static float player_z_coord;
    private GameObject player;
    public static string currentLevel;
    public static bool game_paused;
    private static GameState instance = null;



    void Start(){
        game_paused = false;
        InvokeRepeating("Update", 1f, 1f);
    }

    void Awake(){
        if (instance == null){
            instance = this;
            DontDestroyOnLoad(this.gameObject);
            return;
        }
        Destroy(this.gameObject);
    }

    void Update(){
        //Debug.Log(player_x_coord);
        currentLevel = SceneManager.GetActiveScene().name;
        if (currentLevel != "PauseMenu"){
            player = GameObject.Find("Player");
            if (game_paused == true){
                //i have no idea why the player gameobject drops its y-coord whenever i pause the game. The + 2.5 is a artificial patchup
                player.transform.position = new Vector3(player_x_coord, player_y_coord + (float)2.5, 0);
                //game_paused = false;
            }
            else{
                player_x_coord = player.transform.position.x;
                player_y_coord = player.transform.position.x;
                player_z_coord = player.transform.position.x;
            }
        }

        
    }
}
