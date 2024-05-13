using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DungeonMasterModuleSaver
{
    [Serializable]
    class DMTree
    {
        protected DMNode root;
        protected List<string> nodeNames;

        public DMTree(DMNode root)
        {
            this.root = root;

            this.nodeNames = new List<string>
            {
                root.Name
            };
        }
        public void ChangeNodeName(string nodeName, string newName)
        {
            if (!(this.nodeNames.Contains(nodeName) && !this.nodeNames.Contains(newName))) return;
            var node = Search(nodeName);
            if (node == null) return;
            node.Name = newName;
            nodeNames.Remove(nodeName);
            nodeNames.Add(newName);
        }
        public void AddNode(string name, DMNode node)
        {
            if (node == null) return;
            if (!(this.nodeNames.Contains(name) && !this.nodeNames.Contains(node.Name))) return;
            this.nodeNames.Add(node.Name);
            var parent_node = Search(name);
            parent_node.AddNode(node);
        }
        public void RemoveNode(string name) 
        {
            if (!(this.nodeNames.Contains(name))) return;
            var parent = this.GetParent(this.Search(name));
            if(parent != null)
            {
                this.nodeNames.Remove(name);
                parent.RemoveNode(name);
            }
               
        }
        public DMNode GetParent(DMNode child)
        {
            return GetParent(child, this.root);
        }
        public DMNode GetParent(DMNode child, DMNode root)
        {
            if (root == null) return null;
            else if (root.Nodes.Count > 0)
            {
                var children = root.Nodes;
                foreach (var child1 in children)
                {
                    if (child1.Name == child.Name) return root;
                    else
                    {
                        var parent = GetParent(child, child1);
                        if (parent != null) return parent;
                    }
                }
            }
            return null;
        }
        public DMNode Search(string name)
        {
            return Search(name, this.root);
        }
        public DMNode Search(string name, DMNode root)
        {
            if(root == null) return null;
            if (root.Name == name) return root;
            else if (root.Nodes.Count > 0)
            {
                var children = root.Nodes;
                foreach (var child in children)
                {
                    var child_node = Search(name, child);
                    if (child_node != null) return child_node;
                }
            }
            return null;
        }
        public TreeNode GetTreeNode()
        {
            return GetTreeNode(this.root);
        }
        public static TreeNode GetTreeNode(DMNode root)
        {
            if (root == null) return null;
            TreeNode node = new TreeNode(root.Name);
            //Задаем индекс иконки
            node.ImageIndex = root.IconID;
            node.SelectedImageIndex = root.IconID;

            if (root.Nodes.Count > 0 ) 
            {
                var children = root.Nodes;
                foreach ( var child in children ) 
                {
                    TreeNode child_node = GetTreeNode(child);
                    if(child_node != null) { node.Nodes.Add(child_node); }
                }
            }
            return node;
        }
        public DMNode Root { get { return root; } }

    }
    [Serializable]
    abstract class DMNode
    {
        protected string name, description, other;
        protected List<DMNode> children;
        protected int icon_id;
        protected bool isDead;
        
        public DMNode() : this("Новый узел")
        {
            
        }
        public DMNode(string name)
        {
            this.name = name;
            this.description = "";
            this.other = "";
            this.isDead = false;
            children = new List<DMNode>();
        }
        public void AddNode(DMNode node)
        {
            if (node == null)
                throw new ArgumentException("Добавление пустого узла невозможно!");
            this.children.Add(node);
        }
        public void RemoveNode(string nodeName)
        {
            if (this.children.Count == 0)
                throw new ArgumentException("Невозможно удалить узел с таким именем!");

            foreach(var node in this.children)
            {
                if(node.Name == nodeName)
                {
                    this.children.Remove(node);
                    break;
                }
                    
            }
        }
        public string Name { get { return name; } set { name = value; } }
        public string Description { get { return description; } set { description = value; } }
        public string Other { get { return other; } set { other = value; } }
        public int IconID { get { return icon_id; } }
        public bool IsDead { get { return isDead; } set { isDead = value; } }
        public List<DMNode> Nodes { get { return children; }}
    }
    [Serializable]
    class DMNoteNode : DMNode
    {
        public DMNoteNode() : base() { icon_id = 2; }
        public DMNoteNode(string name) : base(name) { icon_id = 2; }

        
    }
    [Serializable]
    class DMCreatureNode : DMNode
    {
        public DMCreatureNode() : base() { icon_id = 1; }
        public DMCreatureNode(string name) : base(name) { icon_id = 1; }
        
    }
    [Serializable]
    class DMLocationNode : DMNode
    {
        public DMLocationNode() : base() { icon_id = 0; }
        public DMLocationNode(string name) : base(name) { icon_id = 0; }
        
    }
}
