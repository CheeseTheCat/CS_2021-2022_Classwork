using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bunkers : MonoBehaviour
{
    [SerializeField]
    private List<BaseScript> bunkers;

    public int baseCount
    {
        get
        {
            return bunkers.Count;
        }
    }

    public BaseScript randomBase()
    {

        for (int i = baseCount - 1; i >= 0; i--)
        {
            if (bunkers[i].curHP <= 0)
            {
                bunkers.RemoveAt(i);
            }
        }


        return bunkers[Random.Range(0, baseCount - 1)];
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
