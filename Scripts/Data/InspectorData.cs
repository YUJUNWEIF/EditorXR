﻿using System.Collections.Generic;
using Unity.Labs.ListView;

namespace UnityEditor.Experimental.EditorVR.Data
{
    class InspectorData : NestedListViewItemData<InspectorData, int>
    {
        public SerializedObject serializedObject { get; private set; }

        public InspectorData(string template, SerializedObject serializedObject, List<InspectorData> children)
        {
            this.template = template;
            this.serializedObject = serializedObject;
            index = serializedObject.targetObject.GetInstanceID();
            m_Children = children;
        }
    }
}
