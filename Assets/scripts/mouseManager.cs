using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class mouseManager : MonoBehaviour {

    private GameObject hoverObject;
    public Text uiOverlay;
	// Update is called once per frame
	void Update () {

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitInfo;
        if (Physics.Raycast(ray, out hitInfo))
        {
            GameObject hitObject = hitInfo.transform.root.gameObject;
            HoverObject(hitObject);
        }
	}

    void HoverObject(GameObject obj)
    {
        if (obj != null)
        {
            if (obj == hoverObject)
            {
                return;
            }
            ClearSelection();
            hoverObject = obj;
            hexScript hs = hoverObject.GetComponent<hexScript>();
            uiOverlay.text = hs.x + "," + hs.y + ": " + hs.Sysname;
            hs.selected();
        }
    }

    void SelectObject(GameObject hitObj)
    {
        hexScript hs = hitObj.GetComponent<hexScript>();
      
    }

    void ClearSelection()
    {
        if (hoverObject != null)
        {
            hexScript hs = hoverObject.GetComponent<hexScript>();
            hs.unselected();
        }
    }
}
