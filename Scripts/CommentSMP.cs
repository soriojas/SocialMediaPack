using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommentSMP : MonoBehaviour
{
    [TextArea(0,20)]
    [Tooltip("Insert comment here.")]
    public string Text = "Insert comment here.";
}
