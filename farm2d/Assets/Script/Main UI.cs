using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // UI �� �������ؼ� ����Ƽ ������ �ý��� �߰�

public class MainUI : MonoBehaviour
{
    /*
     *  ���� UI ���� 4���� �� �μ� UI 3����
     *  ���� ��� : ������ ���� ǥ��( ����� �̸�, ����ġ, ��)
     *  ���� �ϴ� : ����� ��ų ��ư
     *      - ������ �ڽ� UI�� �θ� UI�� ��ư ������ �� Ȱ��ȭ
     *  ���� ��� : ���� ��¥ �ð� ���� 
     *  ���� �ϴ� : �޴��� 
     *      - �޴� ��ư�� ������ �޴��� �ڽ� UI�� Ȱ��ȭ
     *          - �޴����� �� ��ư���� ���� UI Ȱ��ȭ
     */

    public GameObject profilePanel; // ������ ���� �г�


    public GameObject inventoryPanel; // ��ų�� ���� ��ư �г�


    public GameObject InfoPanel; // ���� ���� �г�


    public GameObject menuPanel; // �޴� ��
    public Button[] menuButtons; // �޴� ���� ��ư�� ���� ����Ʈ
    public GameObject settingPanel; // �ɼ� �г�

    
    // Start is called before the first frame update
    void Start()
    {
        menuPanel.SetActive(false);
        inventoryPanel.SetActive(false);
        settingPanel.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // �޴��� Ȱ��ȭ ��ư �ż���
    public void MenuOpen()
    {
        if (menuPanel != null) // �޴� �г� ������Ʈ�� �Ҵ�Ǿ�������
        {
            if (menuPanel.activeSelf) // �޴��� ������Ʈ�� ���� ������
            {
                menuPanel.SetActive(false); // �޴��ٸ� ����

            }
            else // �޴��ٰ� ����������
            {
                menuPanel.SetActive(true); // �޴��ٸ� �ѱ�
            }
        }
       
    }

    // �޴����� ��ư Ŭ���� ȣ��Ǵ� �ż���
    public void MenuButton(int buttonIndex) 
    {
        // ��ư�� �ε����� ���� ����ġ ������ �޼��� ȣ��
        switch (buttonIndex)
        {
            case 0:
                /*
                 *  �̴ϰ��� �� �����ϴ� �ڵ� ����ֱ�
                 */
                break;
            case 1:

                if (inventoryPanel.activeSelf) // �����г� ������Ʈ�� ���� ������
                {
                    inventoryPanel.SetActive(false); // �����г��� ����

                }
                else // �޴��ٰ� ����������
                {
                    inventoryPanel.SetActive(true); // �����г��� �ѱ�
                }

                break;
            case 2:
                /*
                 * ������Ʈ ��ġ�� ���������
                 * �����ϴ� ���������
                 * �޼��� �Լ� ����ֱ�
                 */

                break;
            case 3:
                /* ���� â �г� �ѱ� ���� 
                 * 
                 *  �̰��� ����Ʈ â �г� UI�� Ű�� ����
                 *  �ڵ带 ����ֱ�
                 * 
                 */
                break;
            case 4:
                /*����Ʈ â �г� �ѱ� ���� 
                 * 
                 *  �̰��� ����Ʈ â �г� UI�� Ű�� ����
                 *  �ڵ带 ����ֱ�
                 * 
                 */
                break;
            case 5:
                if (settingPanel.activeSelf) // �����г� ������Ʈ�� ���� ������
                {
                    settingPanel.SetActive(false); // �����г��� ����

                }
                else // �޴��ٰ� ����������
                {
                    settingPanel.SetActive(true); // �����г��� �ѱ�
                }
                break;
            case 6:
                MenuOpen();
                break;
            // �߰����� ��ư�� ���� ���̽��� �ʿ��ϴٸ� ���⿡ �߰�
            default:
                Debug.Log("Unknown button index");
                break;
        }

    }
}