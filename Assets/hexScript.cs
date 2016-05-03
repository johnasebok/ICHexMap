using UnityEngine;
using System.Collections;

public class hexScript : MonoBehaviour {
    public int x;
    public int y;
    public string Sysname;
    public hexScript(SystemDetails s)
    {
        x = s.x;
        y = s.y;
        Sysname = s.Sysname;
    }

}
