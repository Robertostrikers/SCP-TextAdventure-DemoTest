using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
 * Este codigo permite crear un gameobject "state".
 * El object "state" guarda informacion string (nombrado storyText)
 * */

[CreateAssetMenu(menuName = "State")]
public class State : ScriptableObject
{
    // Start is called before the first frame update
    [TextArea(30, 30)] [SerializeField] string storyText;
    [SerializeField] State[] nextStates;

    public string GetStateStory()
    {
        return storyText;
    }

    public State[] GetNextStates()
    {
        return nextStates;
    }
}



