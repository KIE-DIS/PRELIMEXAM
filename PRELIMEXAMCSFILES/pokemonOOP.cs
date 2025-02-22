using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class pokemonOOP : MonoBehaviour
{
    public GameObject buttonPrefab;
    public Transform buttonContainer;
    public TMP_InputField pokemonInput;
    public TMP_InputField levelInput;
    public TMP_Dropdown elementInput;
    public TMP_Dropdown genderInput;
    public Button addToList;

    private List<pokeDex> pokemonList = new List<pokeDex>();

    public void Start()
    {
        //elementInput.ClearOptions();
        elementInput.AddOptions(new List <string>{"Fire", "Water", "Grass"});
        //genderInput.ClearOptions();
        genderInput.AddOptions(new List <string>{"Male", "Female"});
        addToList.onClick.AddListener(pokeAdd);

    }

    public void pokeAdd()
    {
        string name = pokemonInput.text;
        int level;
        if(!int.TryParse(levelInput.text, out level) || level <= 0)
        {
            Debug.Log("Invalid level.Please enter a positive number.");
            return;
        }
        string element = elementInput.options[elementInput.value].text;
        string gender = genderInput.options[genderInput.value].text;
        pokeDex newPokemon = new pokeDex(name, level, element, gender);
        pokemonList.Add(newPokemon);
        Debug.Log($"pokemon added: {name}, level: {level}, element: {element}, gender: {gender}");
    }

    public void OnClickPokeButton(pokeDex pokeButton)
    {
        
    }
}
