using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour {
	//Functions used are called on button presses. Functions assigned on a button are assigned in the inspector


	public void LoadScene(string scene){
		//Loads the given scene
		SceneManager.LoadScene(scene);
	}

	public void QuitGame(){
		//Closes the game
		Application.Quit ();
	}

	public void IgnoreNPC()
    {
        //Loads the previously stored scene in InterrogationScript.
        //Only used in the interogation room.
        //makes that npc untalkable to untill anothe clue is found
        GameMaster.instance.ignoreNPC(InterrogationScript.instance.GetInterrogationCharacter());
        string previousScene = InterrogationScript.instance.GetReturnScene();
        SceneManager.LoadScene(previousScene);
    }
}
