using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;



public class PopulatePlanets : MonoBehaviour {
   public TextAsset jsonPlanets;
   public GameObject planetPreFab;
    public int width;
    public int height;
    public float xOffSet;
    public float yOffSet;
    public Material usedSystem;
    public List<hexScript> universe;
	// Use this for initialization
   void Start() 
   {
        Systems s = JsonUtility.FromJson<Systems>(jsonPlanets.text);

       //create hex layout
        for (int y = 1; y <= width; y++)
        {
            float oddRowMod = xOffSet / 2;
            if (y % 2 == 0)
            {
                oddRowMod = 0;
            }
            for (int x = 1; x <= width;x++)
            {
 
                GameObject GOsectorHex = (GameObject)Instantiate(planetPreFab, new Vector3(x * xOffSet+oddRowMod, y * yOffSet, 0), Quaternion.identity);
                hexScript sectorHex = GOsectorHex.GetComponent<hexScript>();
                sectorHex.setText(x.ToString() + "," + y.ToString());
                sectorHex.gameObject.name = x + "," + y;
                sectorHex.x = x;
                sectorHex.y = y;
                sectorHex.Sysname = "Empty";
                universe.Add(sectorHex);
            }
        }

        //find system hexes and show systems
        foreach (SystemDetails si in s.systemDetails)
        {
            try {
                hexScript sdFound = universe.Where(a => a.x == si.x && a.y == si.y).First();
                sdFound.setHexScript(si);
                sdFound.GetComponent<MeshRenderer>().material = usedSystem;
                sdFound.transform.Find("systemEffect").gameObject.SetActive(true);
                print("good:"+si.x + "," + si.y);
            }
            catch 
            {
                print(si.x + "," + si.y);
            }
        }

    }
	

}
