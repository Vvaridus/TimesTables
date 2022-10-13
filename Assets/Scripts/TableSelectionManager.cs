using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TableSelectionManager : MonoBehaviour
{
    public static TableSelectionManager instance;
    public static TableSelectionManager MyInstance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<TableSelectionManager>();
            }
            return instance;
        }
    }

    public int selectedTable;

    public void TableSelected(int selected)
    {
        selectedTable = selected;
    }
}
