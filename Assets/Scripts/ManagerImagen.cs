using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ManagerImagen : MonoBehaviour
{
    public List<Food> foods;
    public Image imagen;
    public TextMeshProUGUI texto;

    public Button der;
    public Button izq;

    private int currentIndex = 0;

    private void Start()
    {
        // Mostrar el primer elemento al iniciar
        MostrarElemento(currentIndex);

        // Configurar los listeners de los botones
        der.onClick.AddListener(MostrarSiguiente);
        izq.onClick.AddListener(MostrarAnterior);
    }

    private void MostrarElemento(int index)
    {
        imagen.sprite = foods[index].imageFood;
        texto.text = foods[index].descriptionFood;
    }

    private void MostrarSiguiente()
    {
        currentIndex++;
        if (currentIndex >= foods.Count)
        {
            currentIndex = 0;
        }
        MostrarElemento(currentIndex);
    }

    private void MostrarAnterior()
    {
        currentIndex--;
        if (currentIndex < 0)
        {
            currentIndex = foods.Count - 1; 
        }
        MostrarElemento(currentIndex);
    }
}
