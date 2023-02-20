using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CategorySelector : MonoBehaviour
{
     public int category;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OpenScene(){
        SceneManager.LoadScene("Category " + category.ToString());
    }
}
