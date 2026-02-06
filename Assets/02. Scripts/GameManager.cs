using static Constants;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : Singleton<GameManager>
{
    [SerializeField] private GameObject settingsPanelPrefab;
    [SerializeField] private Canvas canvas;

    private Canvas _canvas;

    //게임 종류 저장
    private GameType _gameType;


    protected override void OnSceneLoad(Scene scene, LoadSceneMode mode)
    {
        // TODO: 씬이 전환될 때 GameManager가 해야 할 일 구현
        _canvas = FindFirstObjectByType<Canvas>();
    }


    //settings 패널 열기
    public void OpenSettingsPanel()
    {
        var settingsPanelObject = Instantiate(settingsPanelPrefab, _canvas.transform);
        settingsPanelObject.GetComponent<SettingsPanelController>().Show();
    }


//씬 전환 (Main -> Game)
    public void ChangeToGameScene(GameType gameType)
    {
        _gameType = gameType;
        SceneManager.LoadScene("Game");
    }


//씬 전환 (Game -> Main)
    public void ChangeToMainScene()
    {
        SceneManager.LoadScene("Main");
        
    }


}
