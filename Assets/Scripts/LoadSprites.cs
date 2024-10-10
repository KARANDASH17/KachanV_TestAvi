using System.Collections;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.UI;

public class LoadSprites : MonoBehaviour {

    public Image[] images;
    public string[] strings;

    public void Load() {
        for (int i = 0; i < images.Length; i++) {
            StartCoroutine(LoadSprite(images[i], i));
        }
    }

    IEnumerator LoadSprite(Image image, int number) {
        var task = Addressables.LoadAssetAsync<Sprite>(strings[number]);
        yield return task;
        image.sprite = task.Result;
        image.enabled = true;
    }

}
