using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DishManager : MonoBehaviour
{
    public List<Dish> dishes;
    public int numCleanDishes = 0;
    public int numDirtyDishes = 0;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    //insert funcitonality to tell the dish to be dirty



    // Update is called once per frame
    void Update()
    {
        numCleanDishes = 0;
        numDirtyDishes = 0;

        for(int i = 0; i < dishes.Count; i++)
        {
            if (dishes[i].clean)
                numCleanDishes++;
            else
                numDirtyDishes++;
        }
    }
}
