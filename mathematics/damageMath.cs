using UnityEngine;
using System.Collections;

public class damageMath : Monobehavior{

public void damage(atkItem, atkChar, defChar){

atkDmg = (((atkChar.acceleration * atkChar.str)/10) * ((atkItem.quality)*(atkItem.abrasion)) /10);

defResistence = ();

finalDmg = atkDmg - defResistence;

}

return finalDmg;

}