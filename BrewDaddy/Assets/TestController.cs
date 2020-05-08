// GENERATED AUTOMATICALLY FROM 'Assets/TestController.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @TestController : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @TestController()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""TestController"",
    ""maps"": [
        {
            ""name"": ""PlayerControls"",
            ""id"": ""d1997fd5-28df-4204-a450-b190e6253265"",
            ""actions"": [
                {
                    ""name"": ""LeftMove"",
                    ""type"": ""PassThrough"",
                    ""id"": ""68db5669-cbac-4754-96d2-53d1b1b7e2b8"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RightMove"",
                    ""type"": ""PassThrough"",
                    ""id"": ""ba4411e9-52f0-4137-b55f-827c1e3db060"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LeftAction"",
                    ""type"": ""Button"",
                    ""id"": ""66f03f99-bb6d-4dfd-9c68-49bdb1e0ec90"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RightAction"",
                    ""type"": ""Button"",
                    ""id"": ""bf7e89ee-ae15-41ad-b94b-9f044a3bc09d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""f979023d-0821-4ce2-a9e5-79442ffe1ac9"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftMove"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""cda9ef03-4a83-486b-9771-3b4e961b83e7"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""3783ec2c-87a5-4132-be27-4eee51a2aed2"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""894791a4-bbe2-4cdc-ab31-10bb63b0d76e"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""fb277079-786e-430c-aeb5-c6530e130a5d"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""396c2421-84bd-46c5-bfab-2bd52e639bee"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""e14482ee-252d-4bfc-8502-c4fc3a8c4cdc"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightMove"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""1f88ed64-ef31-4047-abd9-911c9353ca8e"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""1237299a-8e13-4e91-9260-f2f29e62fe06"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""87ba3c8e-3fc6-4ee8-b520-b2ffab2295ad"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""f34e19b9-c6a4-452f-bb7b-d6d90f82ec46"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""bbdb8edc-e061-47ab-b727-8840c730c802"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3951c60a-3f3f-4828-ae1c-918dee4a7372"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftAction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""467d72c6-d940-4695-8502-3a77ad381602"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftAction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""26ef840c-d7d8-4ada-bf59-103186214b43"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightAction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bcf6cd37-289e-475f-b095-84323f2c37b1"",
                    ""path"": ""<Keyboard>/numpadEnter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightAction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // PlayerControls
        m_PlayerControls = asset.FindActionMap("PlayerControls", throwIfNotFound: true);
        m_PlayerControls_LeftMove = m_PlayerControls.FindAction("LeftMove", throwIfNotFound: true);
        m_PlayerControls_RightMove = m_PlayerControls.FindAction("RightMove", throwIfNotFound: true);
        m_PlayerControls_LeftAction = m_PlayerControls.FindAction("LeftAction", throwIfNotFound: true);
        m_PlayerControls_RightAction = m_PlayerControls.FindAction("RightAction", throwIfNotFound: true);
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

    // PlayerControls
    private readonly InputActionMap m_PlayerControls;
    private IPlayerControlsActions m_PlayerControlsActionsCallbackInterface;
    private readonly InputAction m_PlayerControls_LeftMove;
    private readonly InputAction m_PlayerControls_RightMove;
    private readonly InputAction m_PlayerControls_LeftAction;
    private readonly InputAction m_PlayerControls_RightAction;
    public struct PlayerControlsActions
    {
        private @TestController m_Wrapper;
        public PlayerControlsActions(@TestController wrapper) { m_Wrapper = wrapper; }
        public InputAction @LeftMove => m_Wrapper.m_PlayerControls_LeftMove;
        public InputAction @RightMove => m_Wrapper.m_PlayerControls_RightMove;
        public InputAction @LeftAction => m_Wrapper.m_PlayerControls_LeftAction;
        public InputAction @RightAction => m_Wrapper.m_PlayerControls_RightAction;
        public InputActionMap Get() { return m_Wrapper.m_PlayerControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerControlsActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerControlsActions instance)
        {
            if (m_Wrapper.m_PlayerControlsActionsCallbackInterface != null)
            {
                @LeftMove.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnLeftMove;
                @LeftMove.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnLeftMove;
                @LeftMove.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnLeftMove;
                @RightMove.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnRightMove;
                @RightMove.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnRightMove;
                @RightMove.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnRightMove;
                @LeftAction.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnLeftAction;
                @LeftAction.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnLeftAction;
                @LeftAction.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnLeftAction;
                @RightAction.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnRightAction;
                @RightAction.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnRightAction;
                @RightAction.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnRightAction;
            }
            m_Wrapper.m_PlayerControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @LeftMove.started += instance.OnLeftMove;
                @LeftMove.performed += instance.OnLeftMove;
                @LeftMove.canceled += instance.OnLeftMove;
                @RightMove.started += instance.OnRightMove;
                @RightMove.performed += instance.OnRightMove;
                @RightMove.canceled += instance.OnRightMove;
                @LeftAction.started += instance.OnLeftAction;
                @LeftAction.performed += instance.OnLeftAction;
                @LeftAction.canceled += instance.OnLeftAction;
                @RightAction.started += instance.OnRightAction;
                @RightAction.performed += instance.OnRightAction;
                @RightAction.canceled += instance.OnRightAction;
            }
        }
    }
    public PlayerControlsActions @PlayerControls => new PlayerControlsActions(this);
    public interface IPlayerControlsActions
    {
        void OnLeftMove(InputAction.CallbackContext context);
        void OnRightMove(InputAction.CallbackContext context);
        void OnLeftAction(InputAction.CallbackContext context);
        void OnRightAction(InputAction.CallbackContext context);
    }
}
