using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class aaa : MonoBehaviour
{
    public RawImage rawImage;

    void Update()
    {
        // タッチ時に呼ばれる
        if (Input.GetMouseButtonDown(0))
        {
            // 別のメディア選択操作がすでに進行中の場合
            if (NativeGallery.IsMediaPickerBusy())
                return;

            // 画像の読み込み (512ピクセル以上の場合は縮小)
            PickImage(512);
        }
    }

    // 画像の読み込み
    private void PickImage(int maxSize)
    {
        // 画像の読み込み
        NativeGallery.Permission permission = NativeGallery.GetImageFromGallery((path) =>
        {
            Debug.Log("Image path: " + path);
            if (path != null)
            {
                // 画像パスからTexture2Dを生成
                Texture2D texture = NativeGallery.LoadImageAtPath(path, maxSize);
                if (texture == null)
                {
                    Debug.Log("Couldn't load texture from " + path);
                    return;
                }

                // RawImageの元テクスチャを破棄
                Destroy(rawImage.texture);

                // RawImageで新規テクスチャを表示
                rawImage.texture = texture;
            }
        });
        Debug.Log("Permission result: " + permission);
    }
}