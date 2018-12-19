﻿using UnityEngine;

namespace DefaultNamespace {
  
  public class TexturedMonoBehaviour : MonoBehaviour {
    
    /// <summary>
    /// Loads the specified material from the resources folder.
    /// The material must be a valid Unity3D material stored in Resources/Materials/
    /// <param name="materialName">The name of the material, as it is stored in Resources/Materials/</param>
    /// </summary>
    public void LoadMaterial(string materialName)
    {
      Debug.Log("Floor texture" + materialName);
            
      var material = Resources.Load("Materials/" + materialName, typeof(Material)) as Material;
			
      Renderer rend = GetComponent<Renderer>();
      if (rend != null && material != null)
      {
        rend.material = material;
      }
    }
    
  }
}