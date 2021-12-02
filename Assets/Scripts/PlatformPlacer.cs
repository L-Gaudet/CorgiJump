//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class PlatformPlacer : RandomTimedObjectPlacer
//{
//    public override void Start()
//    {
//        MinimumTimeToCreation = GameParameters.BeerMinimumTimeToCreation;
//        MaximumTimeToCreation = GameParameters.BeerMaximumTimeToCreation;
//        base.Start();
//    }

//    public override void Create()
//    {
//        Instantiate(Prefab, ScreenPositionTools.RandomWorldLocation(Camera), Quaternion.identity);
//        base.Create();
//    }
//}

