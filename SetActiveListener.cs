using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetActiveListener : KeyActionListener<bool>
{
    public bool disableItself = false;
    public bool disableChildren = false;
    public override void UpdateValue(bool value)
    {
        if (disableItself) this.gameObject.SetActive(value);

        if (disableChildren)
        {
            foreach (var child in GetComponentsInChildren(typeof(Transform), true))
            {
                child.transform.gameObject.SetActive(value);
            }
        }

    }
}
