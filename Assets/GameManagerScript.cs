using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class GameManagerScript : MonoBehaviour
{
    // Load the file of student names
    // On button click in UI, randomly pick student name
    // Assign to text object in GUI the chosen student name


    public string fileName = "default.txt";
    public Text displayName;

    private string[] studentNames;

    // Start is called before the first frame update
    void Start()
    {
        LoadStudentNames();
        ButtonClick();
    }

    private void LoadStudentNames()
    {
        this.studentNames = File.ReadAllLines(fileName);
    }

    public void ButtonClick()
    {
        int i = UnityEngine.Random.Range(0, this.studentNames.Length); // 25 = 0-24
        string name = this.studentNames[i];
        displayName.text = name;
    }

    
  
}
