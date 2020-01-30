using UnityEngine;
using System.Collections;

public class bag_function : Monobehavior{
    public int bag_weight;
    public int bag_max_slots;
    public int bag_max_height;


    public ArrayList bag_itens = new ArrayList(item_id);

    public void newItem (Object item){
        if(bag_itens.Count <= bag_max_slots && item.wheight <= bag_weight && item.height <= bag_weight){
            bag_itens.Add(item_id);
            bag_max_slots -= item.size;
            bag_weight -= item.wheight;
        }
        else{
            return;
        }
    }
}
