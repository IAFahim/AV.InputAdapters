using UnityEngine;

namespace AV.InputAdapters.Runtime
{
    /// <summary>
    /// Provides access to a Ray for raycasting operations.
    /// Interface follows naming guidelines: descriptive type name + descriptive property.
    /// </summary>
    public interface IRayProvider
    {
        Ray Ray { get; }
    }
}
