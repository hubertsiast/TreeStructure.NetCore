using System;
using System.Collections.Generic;
using System.Text;
using TreeSource.Domain.Common;

namespace TreeStructure.Aplication.Nodes
{
    public class Node : IEntity
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public long? ParentId { get; set; }
        public virtual Node Parent { get; set; } 
        public virtual ICollection<Node> Childern { get; set; }

        // Only for EF core
        private Node()
        {

        }

        public Node(string name, long parentId)
        {
            Name = name;
            ParentId = parentId;
        }
        
    }
}
