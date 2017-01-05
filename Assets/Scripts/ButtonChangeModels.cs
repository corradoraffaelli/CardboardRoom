using UnityEngine;
using System.Collections;
using Vuforia;

public class ButtonChangeModels : MonoBehaviour, IVirtualButtonEventHandler
{

    //public bool enabled = true;
   
    public GameObject[] objects;

    int index = 0;

    void Start()
    {
        GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);

        ChangeModel(0);
    }

    public void OnButtonPressed(VirtualButtonAbstractBehaviour vb)
    {
        NextModel();

        Debug.Log("Pressed");
    }

    public void OnButtonReleased(VirtualButtonAbstractBehaviour vb)
    {

    }

    void ChangeModel(int index)
    {
        for (int i = 0; i < objects.Length; i++)
        {
            if (objects[i] != null)
                objects[i].SetActive(false);
        }

        if (objects.Length > index && objects[index] != null)
            objects[index].SetActive(true);
    }

    void NextModel()
    {
        index++;
        if (index >= objects.Length)
            index = 0;

        ChangeModel(index);
    }
    
}
