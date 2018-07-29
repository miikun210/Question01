using UnityEngine;

/// <summary>
/// カメラのテスト<br>
/// 
/// </summary>
public class RenderCameraScript : MonoBehaviour
{
    /// <summary>
    /// 描画テストマテリアル
    /// </summary>
    public Material mat;
    /// <summary>
    /// ユニティのポストプロセス関数
    /// </summary>
    /// <param name="source">生成済みの画像</param>
    /// <param name="destination">操作して出力する画像</param>
    void OnRenderImage (RenderTexture source, RenderTexture destination) 
    {
        var rt = RenderTexture.GetTemporary (source.width, source.height, 24, source.format);
        Graphics.SetRenderTarget(rt.colorBuffer, source.depthBuffer);
        Graphics.Blit (source, rt, mat );
        Graphics.Blit(rt, destination);
        RenderTexture.ReleaseTemporary(rt);
    }

}