using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimplePrefs;

[SaveFieldPrimaryKey("MoneyPleyer")]
public struct DataSaves: IData
{
    [SaveField]
    public int goldMoney;
    [SaveField]
    public int silverMoney;
    

}
