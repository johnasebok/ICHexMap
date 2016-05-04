using UnityEngine;
using System.Collections;

public class hexScript : MonoBehaviour {
    public int x;
    public int y;
    public string Sysname;
    public Material baseMateral;
    public Material selectedMateral;
    //0=default
    //0=select
    
    public void setHexScript(SystemDetails s)
    {
        x = s.x;
        y = s.y;
        Sysname = s.Sysname;
        
        string stop="";
    }

    public void setText(string textIN)
    {
        TextMesh tm = (TextMesh)transform.FindChild("CordText").GetComponent<TextMesh>();
        tm.text = textIN;
    }

    public void setRotation()
    {
        Animator a = GetComponentInChildren<Animator>();
        a.speed = Random.Range(0.01f, 0.2f);
    }

    public void unselected()
    {
        GetComponent<MeshRenderer>().material = baseMateral;
    }

    public void selected()
    {
        baseMateral = GetComponent<MeshRenderer>().material;
        GetComponent<MeshRenderer>().material = selectedMateral;
    }
}
