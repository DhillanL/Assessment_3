using UnityEngine;
using System.Collections;

public class ItemScript : MonoBehaviour {
	//Placed on the item prefabs
	//Much like the characterinteraction script:
	//-Tells the prefab which item it is
	//-Adds the item to the inventory when clicked on.

	//__Variables__
	private Item item = null;

	//Called when the item is clicked on 
	void OnMouseDown(){
		//Adds the item to the inventory, updates the notebook and destroys the item gameobject.
		NotebookManager.instance.inventory.AddItemToInventory (item);
		NotebookManager.instance.UpdateNotebook();
        GameObject.FindWithTag("local").GetComponent<QuestioningScript>().unignoreNPC();
        Destroy (gameObject);

	}

	//Sets the item for the prefab
	public void SetItem(Item item){
		this.item = item;
	}
}
