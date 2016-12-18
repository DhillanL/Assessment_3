﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class NotebookManager : MonoBehaviour {

	public Inventory inventory = new Inventory();
	public Logbook logbook = new Logbook();
	public static NotebookManager instance = null;

	public Text[] clueTexts = new Text[20]; 
	public Button[] clueButtons = new Button[20]; 
	public Text clueNameText;
	public Text clueDescriptionText;
	public Image clueImage;
	public int requiredNumberOfClues = 3;
	public Text clueTitle;

	void Awake () {  //Makes this a singleton class on awake
		if (instance == null) { //Does an instance already exist?
			instance = this;	//If not set instance to this
		} else if (instance != this) { //If it already exists and is not this then destroy this
			Destroy (gameObject);
		}
		DontDestroyOnLoad (gameObject); //Set this to not be destroyed when reloading scene
	}

	public void UpdateNotebook(){
		int topOfList = 0;
		//Update Listing
		for (int i = 0; i < (inventory.GetListLength()); i++) {
			clueTexts [i].text = " - "+inventory.GetInventory () [i].getID ();
			topOfList = i;
		}
		for (int j = topOfList; j < (logbook.GetListLength()); j++) {
			clueTexts [j].text = " - "+logbook.GetLogbook () [j].getID ();
		}
		clueTitle.text = "Clues (" + (inventory.GetListLength () + logbook.GetListLength ()) + "/" + requiredNumberOfClues + ")";
	}
		
	public void ShowClueInfomation(int index){
		
		if (index < inventory.GetInventory ().Count) {
			Item clue = inventory.GetInventory () [index];
			clueNameText.text = clue.getID ();  
			clueDescriptionText.text = clue.getDescription ();
			clueImage.sprite = clue.GetSprite ();
		} else {
			VerbalClue clue = logbook.GetLogbook () [index - inventory.GetInventory ().Count];
			clueNameText.text = clue.getID ();  
			clueDescriptionText.text = clue.getDescription ();
			clueImage.sprite = null;
		}
	}
}
