using UnityEngine;
using UnityEngine.SceneManagement;

public class SettingsPanelController : PanelController
{
    //TODO : 스위치 관련 기능 구현 (생략)

    // protected override void OnSceneLoad(Scene scene, LoadSceneMode mode)
    // {
        
    // }

    // public void OpenSettingspanel()
    // {
        
    // }

    public void OnClickCloseButton()
    {
        Hide();
    }
}
