# NormcoreXR
Test repo for Normal's "Normcore 2.0", using Unity XR Rig locomotion

* Using Unity 2020.1.16f1, Normcore 2.0.3, Unity XR Toolkit v0.10.0-preview.7
* Scene "mainSceneXR" is set up with Normcore Realtime Manager: prefab "XRRigNormcore" is properly instantiated
* BUT: When we try to set up the XRRigNormcore prefab for Normcore (i.e. assign head, left/right hand in "Realtime Avatar Manager" component), placement of hands in VR is weirdly offset.  Also: teleportation will no longer work (do we need to go through the hassle of grabbing Normcore "ownership" when locomotion happens?  Not a feature of Avatar Manager already?).  Also: continuous movement seems to work (locally), but is not visible to other players connected through Normcore.


Note: Add your own Normcore App Key to the "Normcore Manager" object in MainSceneXR before starting
