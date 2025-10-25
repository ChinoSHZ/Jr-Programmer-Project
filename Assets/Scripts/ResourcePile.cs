using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A subclass of Building that produce resource at a constant rate.
/// </summary>
public class ResourcePile : Building
{
    public ResourceItem Item;

    // public float ProductionSpeed = 0.5f;

    private float m_CurrentProduction = 0.0f;

    private float m_ProductionSpeed = 0.5f; // add new private backing field

    public float ProductionSpeed // delete semicolon
    {
        get { return m_ProductionSpeed; } // getter returns backing field
        // El "setter" aplica la validación de tus instrucciones
        set
        {
            if (value < 0.0f)
            {
                Debug.LogError("You can't set a negative production speed!");
            }
            else
            {
                m_ProductionSpeed = value; // Se establece el valor si es positivo
            }
        }
    }

    private void Update()
    {
        if (m_CurrentProduction > 1.0f)
        {
            int amountToAdd = Mathf.FloorToInt(m_CurrentProduction);
            int leftOver = AddItem(Item.Id, amountToAdd);

            m_CurrentProduction = m_CurrentProduction - amountToAdd + leftOver;
        }
        
        if (m_CurrentProduction < 1.0f)
        {
            // m_CurrentProduction += ProductionSpeed * Time.deltaTime;

            m_CurrentProduction += m_ProductionSpeed * Time.deltaTime; // swap in m_ version
        }
    }

    public override string GetData()
    {
        // return $"Producing at the speed of {ProductionSpeed}/s";

        return $"Producing at the speed of {m_ProductionSpeed}/s"; // swap in m_ version
    }
    
    
}
