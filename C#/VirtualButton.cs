using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// первым делом подключаем библиотеку Vuforia:
using Vuforia;

// добавляем обработчик событий виртуальной кнопки IVirtualButtonEventHandler:
public class VirtualButton : MonoBehaviour, IVirtualButtonEventHandler
{ 
// Но он будет выдавать ошибку, если не добавить два метода
public GameObject vbBtnObject; // объект для кнопки
public Animator animObject;

        // Start is called before the first frame update
        void Start()
        {
        vbBtnObject = GameObject.Find("VirtualButton");
        vbBtnObject.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        animObject.GetComponent<Animator>();
        }

        // задаем действие кнопки в нажатом состоянии:
        public void OnButtonPressed(VirtualButtonBehaviour vb)
        {
        // включаем воспроизведение анимации с названием "object_animation"
        animObject.Play("object_animation");
        Debug.Log("Работает");
        }

        // задаем действие кнопки в спокойном состоянии (не нажатом):
        public void OnButtonReleased(VirtualButtonBehaviour vb)
        {
            animObject.Play("none");
        }
}
