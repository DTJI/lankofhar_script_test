using UnityEngine;
using System.Collections;

public class damageMath : Monobehavior{

public void damage(atkItem, atkChar, defChar){

atkDmg = (((atkChar.acceleration * atkChar.str)/10) * ((atkItem.quality)*(atkItem.abrasion)) /10);

defResistence = ((defChar.armorQuality)*(defChar.armorAbrasion)/10);

finalDmg = atkDmg - defResistence;

}

return: finalDmg;

}