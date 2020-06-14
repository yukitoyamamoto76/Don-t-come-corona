using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class ButtonScript : MonoBehaviour {

  bool pushl = false;
  bool pushr = false;
  bool pushd = false;
  bool pushu = false;
 
  public void PushDownl(){
   pushl = true;
  }
  public void PushDownr(){
   pushr = true;
  }
  public void PushDownu(){
   pushu = true;
  }
  public void PushDownd(){
   pushd = true;
  }

 
  public void PushUpl(){
   pushl = false;
  }
  public void PushUpr(){
   pushr = false;
  }
  public void PushUpu(){
   pushu = false;
  }
  public void PushUpd(){
   pushd = false;
  }
 
  void Update(){
    if(pushl){
      Movel();
    }
    if(pushr){
      Mover();
    }
    if(pushl){
      Moveu();
    }
    if(pushl){
      Moved();
    }
  }
  


    public void Movel()
    {    
        GameObject player = GameObject.FindGameObjectWithTag("Player");
            player.transform.Translate (-0.1f,0.0f,0.0f);
    }
    public void Mover()
    {    
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        player.transform.Translate (0.1f,0.0f,0.0f);
    }
    public void Moveu()
    {    
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        player.transform.Translate (0.0f,0.0f,0.1f);
    }
    public void Moved()
    {    
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        player.transform.Translate (0.0f,0.0f,-0.1f);
    }
    }
