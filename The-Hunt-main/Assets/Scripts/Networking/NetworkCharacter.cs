using Photon.Pun;
using StarterAssets;
using UnityEngine;
using UnityStandardAssets.Characters.ThirdPerson.PunDemos;

public class NetworkCharacter : MonoBehaviourPunCallbacks, IPunInstantiateMagicCallback
{
    [SerializeField] private ThirdPersonController _thirdPersonController;
    [SerializeField] private AudioManager _audioManager;
    public void OnPhotonInstantiate(PhotonMessageInfo info)
    {
        Debug.Log($"Instantiated {name}");

        info.Sender.TagObject = gameObject;
        _thirdPersonController.DisableOtherCameras();
    }
}
