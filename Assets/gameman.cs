using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameman : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Button[] buttons = FindObjectsOfType<Button>();
        foreach (var sel in buttons) { }
        string[] roles = new string[9] { "Mayor", "Policeman", "Guard", "Priest", "Detective","Villager","Imposter1", "Imposter2","Prisoner"};
    }
    // Update is called once per frame
    void Update()
    { }
}
// abstract class for all
public abstract class Role
{
    private int _votes;
    private bool _goodPerson;

    public Role(int vote, bool good)
    {
        this._votes = vote;
        this._goodPerson = good;
    }
}

class Mayor
{
    
}