using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TIltleScript : MonoBehaviour
{
    public void OnClickStartButton() //https://dianxnao.com/ボタンクリックでシーン間を遷移%ef%bc%88移動%ef%bc%89する/
    {
        FadeManager.Instance.LoadScene("Maine", 2.0f);
    }
}
