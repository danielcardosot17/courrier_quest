//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/InputActions/RoguelikeInputactions.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @RoguelikeInputactions : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @RoguelikeInputactions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""RoguelikeInputactions"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""8d1744d5-c289-4e8b-8769-50408f847f2f"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""de409bf0-7e05-4454-85f0-4912af1c1619"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Whistle"",
                    ""type"": ""Button"",
                    ""id"": ""abd9fdd3-5cae-467e-a2c9-9d91813ab052"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Minimap"",
                    ""type"": ""Button"",
                    ""id"": ""b9c00478-e6eb-4bac-a886-b82cadb1e159"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""MoveTouch"",
                    ""type"": ""Button"",
                    ""id"": ""d992d49f-59ed-46f5-bb79-98d9ee9d533d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""TouchPosition"",
                    ""type"": ""Value"",
                    ""id"": ""75577eb4-48ca-446f-b32d-62041d33ce8a"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""TouchMinimap"",
                    ""type"": ""Button"",
                    ""id"": ""0e55fa30-83b7-40f6-ae63-901f79b95727"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""45909c74-94b3-4a94-b58d-b9ff8c6856c4"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""0ac032fc-f346-4168-9331-82e0d10945a7"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""a24518c5-6276-41a4-a76e-afb154e524ab"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""2a609338-2515-4d98-8498-d0c69a359a26"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""95a57425-01e7-4c00-80ff-2dd89e3d9b65"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""668711cd-045b-4b3c-ae04-9771a75cef1e"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Whistle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""97714c92-fa70-4f62-916d-fa0d63bb0fec"",
                    ""path"": ""<Touchscreen>/primaryTouch/tap"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mobile"",
                    ""action"": ""Whistle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a6e5e1f6-586f-4f67-a049-7d00188ef6dd"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": ""Hold"",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Minimap"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7835ee21-2937-4fe6-93b6-d233fc46acd4"",
                    ""path"": ""<Touchscreen>/Press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mobile"",
                    ""action"": ""MoveTouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5c072038-6f35-424b-b260-74fb7276d2c3"",
                    ""path"": ""<Touchscreen>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mobile"",
                    ""action"": ""TouchPosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""aacbc6fd-6314-48b8-a8ee-1f0cbc81628c"",
                    ""path"": ""<Touchscreen>/Press"",
                    ""interactions"": ""MultiTap"",
                    ""processors"": """",
                    ""groups"": ""Mobile"",
                    ""action"": ""TouchMinimap"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""UI"",
            ""id"": ""cacbbcc5-5e6a-4b25-b1cc-fe3148876ee8"",
            ""actions"": [
                {
                    ""name"": ""Accept"",
                    ""type"": ""Button"",
                    ""id"": ""af451d73-78f4-4c1b-a3b1-f126eb11ec1c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""07bf1f6e-240c-4472-9568-7cd2d69a70c8"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Accept"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cda32a5b-3c6c-408e-a04b-f69a097b32c1"",
                    ""path"": ""<Touchscreen>/Press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mobile"",
                    ""action"": ""Accept"",
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
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Mobile"",
            ""bindingGroup"": ""Mobile"",
            ""devices"": [
                {
                    ""devicePath"": ""<Touchscreen>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Move = m_Player.FindAction("Move", throwIfNotFound: true);
        m_Player_Whistle = m_Player.FindAction("Whistle", throwIfNotFound: true);
        m_Player_Minimap = m_Player.FindAction("Minimap", throwIfNotFound: true);
        m_Player_MoveTouch = m_Player.FindAction("MoveTouch", throwIfNotFound: true);
        m_Player_TouchPosition = m_Player.FindAction("TouchPosition", throwIfNotFound: true);
        m_Player_TouchMinimap = m_Player.FindAction("TouchMinimap", throwIfNotFound: true);
        // UI
        m_UI = asset.FindActionMap("UI", throwIfNotFound: true);
        m_UI_Accept = m_UI.FindAction("Accept", throwIfNotFound: true);
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
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_Move;
    private readonly InputAction m_Player_Whistle;
    private readonly InputAction m_Player_Minimap;
    private readonly InputAction m_Player_MoveTouch;
    private readonly InputAction m_Player_TouchPosition;
    private readonly InputAction m_Player_TouchMinimap;
    public struct PlayerActions
    {
        private @RoguelikeInputactions m_Wrapper;
        public PlayerActions(@RoguelikeInputactions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Player_Move;
        public InputAction @Whistle => m_Wrapper.m_Player_Whistle;
        public InputAction @Minimap => m_Wrapper.m_Player_Minimap;
        public InputAction @MoveTouch => m_Wrapper.m_Player_MoveTouch;
        public InputAction @TouchPosition => m_Wrapper.m_Player_TouchPosition;
        public InputAction @TouchMinimap => m_Wrapper.m_Player_TouchMinimap;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Whistle.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnWhistle;
                @Whistle.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnWhistle;
                @Whistle.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnWhistle;
                @Minimap.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMinimap;
                @Minimap.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMinimap;
                @Minimap.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMinimap;
                @MoveTouch.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoveTouch;
                @MoveTouch.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoveTouch;
                @MoveTouch.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoveTouch;
                @TouchPosition.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTouchPosition;
                @TouchPosition.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTouchPosition;
                @TouchPosition.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTouchPosition;
                @TouchMinimap.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTouchMinimap;
                @TouchMinimap.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTouchMinimap;
                @TouchMinimap.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTouchMinimap;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Whistle.started += instance.OnWhistle;
                @Whistle.performed += instance.OnWhistle;
                @Whistle.canceled += instance.OnWhistle;
                @Minimap.started += instance.OnMinimap;
                @Minimap.performed += instance.OnMinimap;
                @Minimap.canceled += instance.OnMinimap;
                @MoveTouch.started += instance.OnMoveTouch;
                @MoveTouch.performed += instance.OnMoveTouch;
                @MoveTouch.canceled += instance.OnMoveTouch;
                @TouchPosition.started += instance.OnTouchPosition;
                @TouchPosition.performed += instance.OnTouchPosition;
                @TouchPosition.canceled += instance.OnTouchPosition;
                @TouchMinimap.started += instance.OnTouchMinimap;
                @TouchMinimap.performed += instance.OnTouchMinimap;
                @TouchMinimap.canceled += instance.OnTouchMinimap;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);

    // UI
    private readonly InputActionMap m_UI;
    private IUIActions m_UIActionsCallbackInterface;
    private readonly InputAction m_UI_Accept;
    public struct UIActions
    {
        private @RoguelikeInputactions m_Wrapper;
        public UIActions(@RoguelikeInputactions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Accept => m_Wrapper.m_UI_Accept;
        public InputActionMap Get() { return m_Wrapper.m_UI; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(UIActions set) { return set.Get(); }
        public void SetCallbacks(IUIActions instance)
        {
            if (m_Wrapper.m_UIActionsCallbackInterface != null)
            {
                @Accept.started -= m_Wrapper.m_UIActionsCallbackInterface.OnAccept;
                @Accept.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnAccept;
                @Accept.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnAccept;
            }
            m_Wrapper.m_UIActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Accept.started += instance.OnAccept;
                @Accept.performed += instance.OnAccept;
                @Accept.canceled += instance.OnAccept;
            }
        }
    }
    public UIActions @UI => new UIActions(this);
    private int m_KeyboardSchemeIndex = -1;
    public InputControlScheme KeyboardScheme
    {
        get
        {
            if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
            return asset.controlSchemes[m_KeyboardSchemeIndex];
        }
    }
    private int m_MobileSchemeIndex = -1;
    public InputControlScheme MobileScheme
    {
        get
        {
            if (m_MobileSchemeIndex == -1) m_MobileSchemeIndex = asset.FindControlSchemeIndex("Mobile");
            return asset.controlSchemes[m_MobileSchemeIndex];
        }
    }
    public interface IPlayerActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnWhistle(InputAction.CallbackContext context);
        void OnMinimap(InputAction.CallbackContext context);
        void OnMoveTouch(InputAction.CallbackContext context);
        void OnTouchPosition(InputAction.CallbackContext context);
        void OnTouchMinimap(InputAction.CallbackContext context);
    }
    public interface IUIActions
    {
        void OnAccept(InputAction.CallbackContext context);
    }
}
