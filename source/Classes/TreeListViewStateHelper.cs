using System;
using System.Collections;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;
using DevExpress.XtraTreeList.Nodes.Operations;
using System.Xml;
using System.IO;

namespace eViewer.Classes
{
    public class TreeListViewStateHelper
    {
        private ArrayList expanded;
        private ArrayList selected;
        private object focused;
        private int topIndex;

        public TreeListViewStateHelper() : this(null) { }
        public TreeListViewStateHelper(TreeList treeList)
        {
            this.treeList = treeList;
            expanded = new ArrayList();
            selected = new ArrayList();
        }

        public void Clear()
        {
            expanded.Clear();
            selected.Clear();
            focused = null;
            topIndex = 0;
        }
        private ArrayList GetExpanded()
        {
            OperationSaveExpanded op = new OperationSaveExpanded();
            TreeList.NodesIterator.DoOperation(op);
            return op.Nodes;
        }
        private ArrayList GetSelected()
        {
            ArrayList al = new ArrayList();
            foreach (TreeListNode node in TreeList.Selection)
                al.Add(node.GetValue(TreeList.KeyFieldName));
            return al;
        }

        public void LoadState(string filename)
        {
            expanded = DeSerializeArrayList(File.ReadAllText(filename));
            TreeList.BeginUpdate();
            try
            {
                TreeList.CollapseAll();
                TreeListNode node;
                foreach (object key in expanded)
                {
                    node = TreeList.FindNodeByKeyID(key);
                    if (node != null)
                        node.Expanded = true;
                }
                foreach (object key in selected)
                {
                    node = TreeList.FindNodeByKeyID(key);
                    if (node != null)
                        TreeList.Selection.Add(node);
                }
                TreeList.FocusedNode = TreeList.FindNodeByKeyID(focused);
            }
            finally
            {
                TreeList.EndUpdate();
                TreeList.TopVisibleNodeIndex = TreeList.GetVisibleIndexByNode(TreeList.FocusedNode) - topIndex;
            }
        }
        public void SaveState(string filename)
        {
            if (TreeList.FocusedNode != null)
            {
                expanded = GetExpanded();
                selected = GetSelected();
                focused = TreeList.FocusedNode[TreeList.KeyFieldName];
                topIndex = TreeList.GetVisibleIndexByNode(TreeList.FocusedNode) - TreeList.TopVisibleNodeIndex;
            }
            else
                Clear();
            SerializeArrayList(expanded, filename);
        }

        private void SerializeArrayList(ArrayList obj, string filename)
        {

            System.Xml.XmlDocument doc = new XmlDocument();

            Type[] extraTypes = new Type[1];

            extraTypes[0] = typeof(string);

            System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(typeof(ArrayList), extraTypes);

            System.IO.MemoryStream stream = new System.IO.MemoryStream();

            try
            {

                serializer.Serialize(stream, obj);

                stream.Position = 0;

                doc.Load(stream);

                File.WriteAllText(filename, doc.InnerXml);
            }

            catch { throw; }

            finally
            {

                stream.Close();

                stream.Dispose();


            }


        }

        private ArrayList DeSerializeArrayList(string serializedData)
        {

            ArrayList list = new ArrayList();

            Type[] extraTypes = new Type[1];

            extraTypes[0] = typeof(string);

            System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(typeof(ArrayList), extraTypes);

            XmlReader xReader = XmlReader.Create(new StringReader(serializedData));

            try
            {

                object obj = serializer.Deserialize(xReader);

                list = (ArrayList)obj;


            }
            catch
            {
                throw;
            }

            finally
            {
                xReader.Close();
            }
            return list;
        }


        private TreeList treeList;
        public TreeList TreeList
        {
            get
            {
                return treeList;
            }
            set
            {
                treeList = value;
                Clear();
            }
        }

        class OperationSaveExpanded : TreeListOperation
        {
            private ArrayList al = new ArrayList();
            public override void Execute(TreeListNode node)
            {
                if (node.HasChildren && node.Expanded)
                    al.Add(node.GetValue(node.TreeList.KeyFieldName));
            }
            public ArrayList Nodes { get { return al; } }
        }
    }
}
