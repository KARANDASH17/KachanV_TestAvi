using UnityEngine;
using UnityEngine.EventSystems;

[RequireComponent(typeof(Animator))]
public class CustomButton : MonoBehaviour, IPointerClickHandler {

    [SerializeField] private LoadSprites loadSprites;
    private Animator animator;


    private void Start()
    {
        animator = GetComponent<Animator>();       
    }
   
    public void OnPointerClick(PointerEventData eventData)
    {
        animator.SetBool("anim", true);
        loadSprites.Load(); 
    }

}
