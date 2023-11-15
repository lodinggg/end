
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public Text customPageTitle;
    public GameObject customPage;
    public GameObject editPage;
    public GameObject savingPanel;
    public GameObject startMenu;
    public GameObject mainCam;
    public GameObject customCam;
    public GameObject plane;
    public GameObject player;
    public Animator animator;
    public Animator animator1;
    public Animator animator2;
    public Animator animator3;
    public GameObject main;
    public GameObject charter;
    public GameObject intro;
    public GameObject startPlane;

    private bool IsGameStarted;
    private bool isEdit;


    private void Start()
    {
        IsGameStarted = false;
        isEdit = false;
    }
    void Update()
    {
        if (!IsGameStarted)
        {
            if (Input.anyKeyDown)
            {
                animator.SetTrigger("IsOpen");
                animator1.SetTrigger("IsOpen");
                animator2.SetTrigger("IsCam");
                Invoke("cam", 2.1f);
                Invoke("cam2", 1.3f);
                plane.SetActive(false);
                IsGameStarted = true;
                mainCam.transform.SetParent(player.transform, true);

            }
        }

    }


    public void cam()
    {
        main.SetActive(false);
        charter.SetActive(true);
        intro.SetActive(false);
    }
    public void cam2()
    {
        player.GetComponent<mouse>().enabled = true;
        animator3.SetTrigger("IsChange");
        startMenu.SetActive(true);
    }
    //메인메뉴 페이지 상호작용
    public void clickedCustomBtn()
    {
        player.GetComponent<mouse>().enabled = false;
        startMenu.SetActive(false);
        customPage.SetActive(true);
        customPageTitle.gameObject.SetActive(true);

        plane.SetActive(true);
        player.transform.position = new Vector3(3, 0, -5);
        player.transform.rotation = Quaternion.Euler(0, 0, 0);
        player.transform.localScale = new Vector3(1, 1, 1);
        mainCam.SetActive(false);
        customCam.SetActive(true);
    }

    public void clicekedStart()
    {
        player.transform.position = new Vector3(3, 0, -5);
        startMenu.SetActive(false);
        startPlane.SetActive(true);
        player.GetComponent<mouse>().enabled = false;
        customCam.transform.position = new Vector3(8.6f, 1.8f, 6.1f);
        customCam.transform.rotation = Quaternion.Euler(180, 60, 90);
    }

    public void clicekedExitBtn()
    {
        Application.Quit();
    }
    //커스텀 페이지 메뉴 상호작용

    public void clickedCustomEditBtn()
    {
        setEdit(true);
    }
    public void clickedBackBtn()
    {
        if (isEdit)
        {
            savingPanel.SetActive(true);

        }
        else
        {
            player.GetComponent<mouse>().enabled = true;
            startMenu.SetActive(true);
            customPage.SetActive(false);
            customPageTitle.gameObject.SetActive(false);
            plane.SetActive(false);
            player.transform.position = new Vector3(3, 0, -5);
            player.transform.rotation = Quaternion.Euler(-90, 0, 150);
            player.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
            mainCam.SetActive(true);
            customCam.SetActive(false);
        }
    }
    private void setEdit(bool _isEdit)
    {
        isEdit = _isEdit;
    }
    public void clickedCustomYes()
    {
        setEdit(false);
        savingPanel.SetActive(false);
        clickedBackBtn();
    }

    public void clickedCustomNo()
    {
        setEdit(false);
        savingPanel.SetActive(false);
        clickedBackBtn();
    }

    public void readyToEdit()
    {
        customPage.SetActive(false);
        editPage.SetActive(true);
    }
}
