using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Die : MonoBehaviour
{
    public GameObject gameOver_UI;

    Move this_move;

    // Start is called before the first frame update
    void Start()
    {
        this_move = this.GetComponent<Move>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Gameover()
    {
        this_move.moveSpeed = -30;
        gameOver_UI.SetActive(true);
    }

    private void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "Meteor")
        {
            Gameover();
        }
    }
}
