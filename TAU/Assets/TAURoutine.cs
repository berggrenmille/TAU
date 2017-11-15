using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TAU
{
    

}
public class TAURoutine : IEnumerator {

    // implements IEnumerator to make it usable by StartCoroutine;
    #region IEnumerator Interface
    /// <summary>
    /// The current iterator yield return value.
    /// </summary>
    public object Current { get; private set; }

    /// <summary>
    /// Runs next iteration.
    /// </summary>
    /// <returns><code>true</code> for continue, otherwise <code>false</code>.</returns>
    public bool MoveNext()
    {
        return OnMoveNext();
    }

    public void Reset()
    {
        // Reset method not supported by iterator;
        throw new System.NotSupportedException(
            "Not support calling Reset() on iterator.");
    }
    #endregion
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
