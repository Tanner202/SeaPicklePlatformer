using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class death_script : MonoBehaviour
{
    // Start is called before the first frame update
    public void Death()
    {
        Debug.Log("DIEEED");
        SceneManager.LoadScene("level");
    }
}
