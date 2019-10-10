using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


/*
 * Este codigo es la fuente principal, 
 */

public class AdventureGame : MonoBehaviour
{

    [SerializeField] Text textComponent;
    [SerializeField] State startingState;

    State state;

    // Start is called before the first frame update
    void Start()
    {
        //llama a un metodo de state.cs para recoger el texto de startingState
        state = startingState;
        textComponent.text = state.GetStateStory();
    }

    // Update is called once per frame
    void Update()
    {
        ManageState();
    }

    private void ManageState()
    {
        var nextStage = state.GetNextStates();
        for (int index =0; index < nextStage.Length; index++)
        {
            if(Input.GetKeyDown(KeyCode.Alpha1+index))
        {
                state = nextStage[index];
            }
        }
        
        textComponent.text = state.GetStateStory(); //El campo texto de objeto texto es igual al campo texto de story text
    }
}
