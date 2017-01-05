using UnityEngine;
using System.Collections;
using Vuforia;

public class ButtonChange : MonoBehaviour, IVirtualButtonEventHandler {
    
    public bool enabled = true;

    public GameObject ulObj;
    public GameObject urOgj;

    public VirtualButtonBehaviour[] buttons;

	void Start () {
	    if (buttons != null && buttons.Length != 0)
        {
            for (int i = 0; i < buttons.Length; i++)
            {
                if (buttons[i] != null)
                    buttons[i].RegisterEventHandler(this);
            }
        }
	}
	
    public void OnButtonPressed(VirtualButtonAbstractBehaviour vb)
    {
        if (vb.gameObject.name == "VirtualButtonUL")
        {
            ulObj.SetActive(!ulObj.activeSelf);
        }

        if (vb.gameObject.name == "VirtualButtonUR")
        {
            urOgj.SetActive(!urOgj.activeSelf);
        }
    }

    public void OnButtonReleased(VirtualButtonAbstractBehaviour vb)
    {

    }
}
