using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelSelect : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void SelectLevel(){
        switch(this.gameObject.name){
            case "Level 1":
                SceneManager.LoadScene("Animal_Level 1");
                break;
            case "Level 2":
                SceneManager.LoadScene("Animal_Level 2");
                break;
            case "Level 3":
                SceneManager.LoadScene("Animal_Level 3");
                break;
            case "Level 4":
                SceneManager.LoadScene("Animal_Level 4");
                break;
            case "Level 5":
                SceneManager.LoadScene("Animal_Level 5");
                break;
            case "Level 6":
                SceneManager.LoadScene("Animal_Level 6");
                break;
            case "Level 7":
                SceneManager.LoadScene("Animal_Level 7");
                break;
            case "Level 8":
                SceneManager.LoadScene("Animal_Level 8");
                break;
            case "Level 9":
                SceneManager.LoadScene("Animal_Level 9");
                break;
            case "Level 10":
                SceneManager.LoadScene("Animal_Level 10");
                break;
        }
    }
    public void OccupationSelectLevel(){
        switch(this.gameObject.name){
            case "Level 1":
                SceneManager.LoadScene("Occupation_Level 1");
                break;
            case "Level 2":
                SceneManager.LoadScene("Occupation_Level 2");
                break;
            case "Level 3":
                SceneManager.LoadScene("Occupation_Level 3");
                break;
            case "Level 4":
                SceneManager.LoadScene("Occupation_Level 4");
                break;
            case "Level 5":
                SceneManager.LoadScene("Occupation_Level 5");
                break;
            case "Level 6":
                SceneManager.LoadScene("Occupation_Level 6");
                break;
            case "Level 7":
                SceneManager.LoadScene("Occupation_Level 7");
                break;
            case "Level 8":
                SceneManager.LoadScene("Occupation_Level 8");
                break;
            case "Level 9":
                SceneManager.LoadScene("Occupation_Level 9");
                break;
            case "Level 10":
                SceneManager.LoadScene("Occupation_Level 10");
                break;
        }
    }
    public void FruitSelectLevel(){
        switch(this.gameObject.name){
            case "Level 1":
                SceneManager.LoadScene("Fruit_Level 1");
                break;
            case "Level 2":
                SceneManager.LoadScene("Fruit_Level 2");
                break;
            case "Level 3":
                SceneManager.LoadScene("Fruit_Level 3");
                break;
            case "Level 4":
                SceneManager.LoadScene("Fruit_Level 4");
                break;
            case "Level 5":
                SceneManager.LoadScene("Fruit_Level 5");
                break;
            case "Level 6":
                SceneManager.LoadScene("Fruit_Level 6");
                break;
            case "Level 7":
                SceneManager.LoadScene("Fruit_Level 7");
                break;
            case "Level 8":
                SceneManager.LoadScene("Fruit_Level 8");
                break;
            case "Level 9":
                SceneManager.LoadScene("Fruit_Level 9");
                break;
            case "Level 10":
                SceneManager.LoadScene("Fruit_Level 10");
                break;
        }
    }
    public void VegetableSelectLevel(){
        switch(this.gameObject.name){
            case "Level 1":
                SceneManager.LoadScene("Vegetable_Level 1");
                break;
            case "Level 2":
                SceneManager.LoadScene("Vegetable_Level 2");
                break;
            case "Level 3":
                SceneManager.LoadScene("Vegetable_Level 3");
                break;
            case "Level 4":
                SceneManager.LoadScene("Vegetable_Level 4");
                break;
            case "Level 5":
                SceneManager.LoadScene("Vegetable_Level 5");
                break;
            case "Level 6":
                SceneManager.LoadScene("Vegetable_Level 6");
                break;
            case "Level 7":
                SceneManager.LoadScene("Vegetable_Level 7");
                break;
            case "Level 8":
                SceneManager.LoadScene("Vegetable_Level 8");
                break;
            case "Level 9":
                SceneManager.LoadScene("Vegetable_Level 9");
                break;
            case "Level 10":
                SceneManager.LoadScene("Vegetable_Level 10");
                break;
        }
    }
    public void PlayGame()
    {
        SceneManager.LoadScene("Animal_LVSelect");
        
    }
    public void PlayFruit()
    {
        SceneManager.LoadScene("Fruit_LVSelect");
        
    }
    public void PlayOccupation()
    {
       SceneManager.LoadScene("Occupation_LVSelect");
        
    }
    public void PlayVegetable()
    {
        SceneManager.LoadScene("Vegetable_LVSelect");
        
    }
}
