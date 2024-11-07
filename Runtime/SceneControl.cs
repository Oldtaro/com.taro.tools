using UnityEngine;
using UnityEngine.SceneManagement;

namespace Taro.Tools
{
    /// <summary>
    /// 場景控制器
    /// </summary>
    public class SceneControl : MonoBehaviour
    {
        /// <summary>
        /// 載入場景
        /// </summary>
        /// <param name="sceneName">場景名稱</param>
        public void LoadScene(string sceneName)
        {
            //使用場景管理器載入場景
            SceneManager.LoadScene(sceneName);
        }
        /// <summary>
        /// 離開遊戲
        /// </summary>
        public void QuitGame()
        {
            //離開遊戲
            Application.Quit();
        }
    }
}

