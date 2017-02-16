using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class TraverseRooms : MonoBehaviour {
	//Used on the map to load the appropriate level.
	//Placed on the child objects of the map defining the hitboxes (Polygon Collider 2D) 

	public string level;	//Public to allow for changing in inspector.

	//When the area on the map is clicked load the respective level
	void OnMouseDown() {
        if (level == "Underground Lab" && GameMaster.instance.iskeyfound())
        {
            SceneManager.LoadScene(level);
        } else if(level == "Underground Lab" && !GameMaster.instance.iskeyfound())
        {

        } else
        {
            SceneManager.LoadScene(level);
        }

 
		
	}
}
