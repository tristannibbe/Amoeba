// GENERATED AUTOMATICALLY FROM 'Assets/Input/UI.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @UI : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @UI()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""UI"",
    ""maps"": [
        {
            ""name"": ""PauseScreen"",
            ""id"": ""ff66fd77-3a02-4f29-a9ff-87ab8061e21b"",
            ""actions"": [
                {
                    ""name"": ""ToggleScreen"",
                    ""type"": ""Button"",
                    ""id"": ""759971d1-433a-485d-bc99-5b5e5591792b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""c10dd119-41b2-4b69-8668-e7d66c8a7444"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""ToggleScreen"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard"",
            ""bindingGroup"": ""Keyboard"",
            ""devices"": []
        }
    ]
}");
        // PauseScreen
        m_PauseScreen = asset.FindActionMap("PauseScreen", throwIfNotFound: true);
        m_PauseScreen_ToggleScreen = m_PauseScreen.FindAction("ToggleScreen", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // PauseScreen
    private readonly InputActionMap m_PauseScreen;
    private IPauseScreenActions m_PauseScreenActionsCallbackInterface;
    private readonly InputAction m_PauseScreen_ToggleScreen;
    public struct PauseScreenActions
    {
        private @UI m_Wrapper;
        public PauseScreenActions(@UI wrapper) { m_Wrapper = wrapper; }
        public InputAction @ToggleScreen => m_Wrapper.m_PauseScreen_ToggleScreen;
        public InputActionMap Get() { return m_Wrapper.m_PauseScreen; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PauseScreenActions set) { return set.Get(); }
        public void SetCallbacks(IPauseScreenActions instance)
        {
            if (m_Wrapper.m_PauseScreenActionsCallbackInterface != null)
            {
                @ToggleScreen.started -= m_Wrapper.m_PauseScreenActionsCallbackInterface.OnToggleScreen;
                @ToggleScreen.performed -= m_Wrapper.m_PauseScreenActionsCallbackInterface.OnToggleScreen;
                @ToggleScreen.canceled -= m_Wrapper.m_PauseScreenActionsCallbackInterface.OnToggleScreen;
            }
            m_Wrapper.m_PauseScreenActionsCallbackInterface = instance;
            if (instance != null)
            {
                @ToggleScreen.started += instance.OnToggleScreen;
                @ToggleScreen.performed += instance.OnToggleScreen;
                @ToggleScreen.canceled += instance.OnToggleScreen;
            }
        }
    }
    public PauseScreenActions @PauseScreen => new PauseScreenActions(this);
    private int m_KeyboardSchemeIndex = -1;
    public InputControlScheme KeyboardScheme
    {
        get
        {
            if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
            return asset.controlSchemes[m_KeyboardSchemeIndex];
        }
    }
    public interface IPauseScreenActions
    {
        void OnToggleScreen(InputAction.CallbackContext context);
    }
}
