using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class pokeButton : MonoBehaviour
{
    public TextMeshProUGUI name;
    public TextMeshProUGUI level;

    public void SetData(pokeDex pokeMon)
    {
        this.name.text = pokeMon.name;
        this.level.text = pokeMon.level.ToString();
    }
}
