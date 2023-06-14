using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CategorySelector : MonoBehaviour
{
     
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void SelectScene(){
        switch(this.gameObject.name){
            case "Animal":
                SceneManager.LoadScene("Volcabulary_Animal");
                break;
            case "Occupations":
                SceneManager.LoadScene("Volcabulary_Occupation");
                break;
            case "Vegetables":
                SceneManager.LoadScene("Volcabulary_Vegetable");
                break;
            case "Fruit":
                SceneManager.LoadScene("Volcabulary_Fruit");
                break;
        }
    }
}
