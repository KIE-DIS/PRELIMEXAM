using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class pokeDex : MonoBehaviour
{
    public string name;
    public int level;
    public string element;
    public string gender;

    public pokeDex(string name, int level, string element, string gender)
    {
        this.name = name;
        this.level = level;
        this.element = element;
        this.gender = gender;
    }
}

//public enum Element { Normal, Fire, Electric, Grass, Ice, Fighting, Poison, Ground, Flying, Psychic, Bug, Rock, Ghost, Dragon, Water, Fairy, Steel, Dark, Stellar }
//public enum Gender { Male, Female }