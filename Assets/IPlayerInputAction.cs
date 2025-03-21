using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public interface IPlayerInputAction
{
    InputActionAsset asset { get; }
    InputBinding? bindingMask { get; set; }
    IEnumerable<InputBinding> bindings { get; }
    ReadOnlyArray<InputControlScheme> controlSchemes { get; }
    ReadOnlyArray<InputDevice>? devices { get; set; }
    PlayerInputAction.PlayerActions Player { get; }

    bool Contains(InputAction action);
    void Disable();
    void Dispose();
    void Enable();
    InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false);
    int FindBinding(InputBinding bindingMask, out InputAction action);
    IEnumerator<InputAction> GetEnumerator();
}