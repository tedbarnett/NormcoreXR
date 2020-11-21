# NormcoreBasic
Test repo for Normal's "Normcore 2.0", using Unity XR Rig locomotion

* Using Unity 2020.1.14f1, Normcore 2.0.3, Unity XR Toolkit v0.10.0-preview.7
* Scene "mainSceneXR" is set up with Normcore Realtime Manager: prefab "XRRigNormcore" is properly instantiated
* BUT: if we try to set up the XRRigNormcore prefab for Normcore (i.e. assign head, left/right hand in "Realtime Avatar Manager" component), placement of head and hands in VR is weirdly offset.  
* Also: teleportation will no longer work (which is expected until we go through the hassle of grabbing Normcore "ownership" when locomotion happens).  Will fix this once the offset issue is resolved!


Note: Add your own Normcore App Key to the "Normcore Manager" object in MainSceneXR before starting
