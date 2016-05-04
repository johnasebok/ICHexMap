using UnityEngine;
using System.Collections;

public class hexScript : MonoBehaviour {
    public int x;
    public int y;
    public string Sysname;
    public void setHexScript(SystemDetails s)
    {
        x = s.x;
        y = s.y;
        Sysname = s.Sysname;
    }

    public void setText(string textIN)
    {
        TextMesh tm = (TextMesh)transform.FindChild("CordText").GetComponent<TextMesh>();
        tm.text = textIN;
    }
}
