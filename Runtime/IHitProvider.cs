using UnityEngine;

namespace AV.InputAdapters.Runtime
{
    /// <summary>
    /// Provides access to a RaycastHit result.
    /// Interface follows naming guidelines: descriptive type name + descriptive property.
    /// </summary>
    public interface IHitProvider
    {
        RaycastHit Hit { get; }
    }
}
